# ASP.NET Application Services State Management

## 1. Setting the Scene

> *“Think of yourself as the guardian of a growing online shop. In the beginning, when only a handful of friends and neighbors bought products, you tracked everything in a notebook — who bought what, whether they paid, and how much stock was left. It worked fine. But soon, the shop caught fire — hundreds of customers, multiple delivery boys, and payments coming from all directions. That notebook? Suddenly it wasn’t enough. Pages got messy, anyone could peek in, and clerks started overwriting each other’s notes. Chaos was knocking.”*

This is where **application services** step in — in ASP.NET Core, they’re the tools that help you manage state, secure access, and structure your app for growth.



## 2. State Management — The Shop’s Notebook

> *“Your notebook is like your application’s state. When small, you can scribble in-memory. But as more clerks (users) arrive, you need copies that travel with them (cookies), or a strong central ledger (session store, cache, or database).”*

In ASP.NET Core, we manage state with:

* **Cookies** (travel with the customer)
* **Session** (short-lived, stored at server)
* **Cache/Database** (durable and scalable)


## 3. Authentication & Authorization — The Cashbox Keys

> *“In the shop, not everyone gets to open the cashbox. Only trusted clerks with keys can touch money. Customers may browse shelves, but only after paying can they leave with goods. This is authentication and authorization.”*

In ASP.NET Core MVC:

* **Authentication** checks identity (credentials verified by a `UserService`).
* **Authorization** checks permission (`[Authorize]` filter, role-based access).
* **Cookies** are like stamped passes customers carry; every request shows the pass.

Code sketch:

```csharp
[Authorize(Roles = "Admin")]
public class AdminController : Controller { ... }
```

## 4. Async Applications — Many Clerks, No Waiting

> *“Imagine only one clerk at the counter. Customers queue endlessly. But if clerks can multitask — one waits for payment confirmation while helping another — the line moves faster.”*

That’s what `async`/`await` brings to controllers. Tasks don’t block; servers handle more requests.


## 5. MongoDB — The Flexible Stockroom

> *“When the shop had 50 products, a simple table was enough. But now, with thousands of variations, changing stock details daily, you need flexible shelves where items don’t all look the same.”*

MongoDB = document store, schema-flexible. ASP.NET Core connects easily with the MongoDB driver.

```csharp
public class ProductRepository {
  private readonly IMongoCollection<Product> _col;
  public ProductRepository(IMongoClient client) => _col = client.GetDatabase("shop").GetCollection<Product>("products");
  public async Task<List<Product>> GetAll() => await _col.Find(_ => true).ToListAsync();
}
```

## 6. RabbitMQ & Kafka — The Shop’s Notice Board

> *“Think of a big blackboard where clerks write: ‘Order #101 placed’. The delivery boy checks it, picks items, and stocks are updated. No one shouts across the room — they just leave notes.”*

* **RabbitMQ**: simple, reliable, task-oriented. Great for order → inventory.
* **Kafka**: high-throughput, streaming, event replay. Great for analyzing customer trends.

Producer sketch:

```csharp
channel.QueueDeclare("orders", durable:true, exclusive:false, autoDelete:false);
var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(order));
channel.BasicPublish(exchange:"", routingKey:"orders", body:body);
```

## 7. Microservices — Splitting Shop Duties

> *“As the shop grows, one person can’t do everything. So duties split: cashier, stock manager, delivery boy, customer care. Each has their own ledger, their own accountability, and they talk through the notice board.”*

In software terms:

* **Auth Service** = cashier issuing passes (tokens/cookies).
* **Catalog Service** = stock manager (MongoDB).
* **Order Service** = creates orders, posts on the board.
* **Inventory Service** = picks order, updates stock.
* **Notification Service** = messages customer.

Pros: scalability, isolation, flexibility.
Cons: complexity, network calls, debugging challenges.


## 8. Capstone Project — TransFlower Online Shopping

Your challenge: expand the monolithic e‑commerce into microservices.

* Sprint 1: Auth + Catalog (MongoDB)
* Sprint 2: Order service + RabbitMQ → Inventory consumer
* Sprint 3: Notifications, retries, logging

Deliverable: Show a customer placing an order → stock reserved → confirmation message.


## 9. Closing Mentor Note

> *“A family shop scales into a supermarket by splitting duties, setting rules, and creating communication boards. In the same way, your ASP.NET applications scale into microservices by using state management, authentication, and messaging tools. Remember, growth demands structure — and structure brings both freedom and responsibility.”*



#  ASP.NET Application Services & Microservices



## 1. Setting the Scene

*"Imagine you’re running a small neighborhood shop. In the early days, you just had a notebook — recording sales, stock, and customer debts. Life was simple. But as customers increased, clerks joined in, payments came from UPI, cards, and cash, and deliveries stretched across the city — that notebook suddenly became chaos. Pages clashed, notes got lost, and no one knew who was in charge."*

This is exactly what happens with **applications** as they scale. ASP.NET Core offers **application services** — state management, authentication, async, data storage — to bring order. And when growth explodes? You split into **microservices**.


## 2. State Management — The Shop’s Notebook

*"Your notebook is your app’s state. Small shop? Keep it in memory. More clerks? Each clerk needs a copy (cookies). Too many customers? You need a central ledger (sessions or cache)."*

ASP.NET Core state tools:

* **Cookies** → Travel with the customer (browser).
* **Session** → Centralized short-term memory (server).
* **Cache / DB** → Durable memory (Redis, SQL, MongoDB).

👉 Code Sketch:

```csharp
// Startup.cs - Adding session
services.AddSession();

app.UseSession();

HttpContext.Session.SetString("CartId", "12345");
var cartId = HttpContext.Session.GetString("CartId");
```


## 3. Authentication & Authorization — Who Holds the Keys?

*"In your shop, not everyone can open the cashbox. Only trusted clerks. Customers can browse, but only after payment can they walk out with goods."*

ASP.NET Core MVC:

* **Authentication** = Verify identity (Who are you?)
* **Authorization** = Verify access (What can you do?)

👉 Code Sketch:

```csharp
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Dashboard() => View();
}
```

Cookies act like stamped passes. Every request must show the pass.


## 4. Async Applications — Many Clerks, No Waiting

*"If you had one clerk, customers wait forever. But if clerks can multitask — waiting for a UPI payment while serving someone else — the line moves faster."*

In ASP.NET:

```csharp
public async Task<IActionResult> GetProducts()
{
    var products = await _repo.GetAll();
    return View(products);
}
```

Non-blocking = More throughput.


## 5. MongoDB — The Flexible Stockroom

*"Your shop sells shirts, books, and plants. Tables force uniformity. But in your stockroom, shelves accept any shape. That’s MongoDB."*

👉 Code Sketch:

```csharp
public class ProductRepository
{
    private readonly IMongoCollection<Product> _col;

    public ProductRepository(IMongoClient client)
    {
        _col = client.GetDatabase("shop").GetCollection<Product>("products");
    }

    public async Task<List<Product>> GetAll() =>
        await _col.Find(_ => true).ToListAsync();
}
```

Schema-flexible, cloud-friendly.


## 6. RabbitMQ & Kafka — The Shop’s Notice Board

*"Instead of clerks shouting across the shop, they write on a blackboard: 'Order #101 placed'. Delivery boy reads it, picks the items, updates stock. Everyone communicates silently through the board."*

* **RabbitMQ** → Reliable task queue (order → inventory).
* **Kafka** → Streaming & replay (analyze customer trends).

👉 Producer Sketch:

```csharp
channel.QueueDeclare("orders", durable:true, exclusive:false, autoDelete:false);
var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(order));
channel.BasicPublish(exchange:"", routingKey:"orders", body:body);
```

## 7. Microservices — Splitting Duties

*"As shop grows, one clerk can’t do it all. Roles split: cashier, stock manager, delivery boy, customer care. Each has its own ledger, but they all talk through the notice board."*

Software equivalent:

* **Auth Service** = Cashier (issues tokens/cookies).
* **Catalog Service** = Stock manager (MongoDB).
* **Order Service** = Places orders, posts to board.
* **Inventory Service** = Reads orders, updates stock.
* **Notification Service** = Sends SMS/Email to customer.

Pros → Scalable, flexible, isolated failures.
Cons → Network overhead, debugging harder.


## 8. Capstone Project — TransFlower Online Shopping

**Goal**: Transform monolith → microservices

* **Sprint 1**: Auth + Catalog (with MongoDB).
* **Sprint 2**: Order → RabbitMQ → Inventory consumer.
* **Sprint 3**: Notifications, retries, centralized logging.

Deliverable:
Customer places an order → stock reserved → confirmation message delivered.


## 9. Closing Mentor Note

\*"Shops that scale into supermarkets don’t do so by chaos — they do it by **splitting duties, setting rules, and communicating through systems**. The same is true for ASP.NET applications.

Application services bring **structure**. Microservices bring **scalability**. Remember — growth demands structure, and structure gives both freedom and responsibility."\*

G

# State Management in ASP.NET Core MVC

### 1. Setting the Scene

*"Imagine you built a small ASP.NET Core MVC app. At first, it’s like a small shop where one clerk writes down things in a notebook. But as customers come in, you need multiple ways to remember what’s happening — what each customer has in their cart, what messages you want to show only once, and how data survives across pages. This is where **state management** steps in."*

In your demo, you’ve got a **solution with a project**: `StateManagementApp`.
You run it with `dotnet run`, and the browser opens at a port number.
Inside the menu, you see options:

* Local Storage
* Session Storage
* Login
* TempData
* Session

These are your **different flavors of state**.


### 2. Client-Side State — Local & Session Storage

*"On the shop floor, sometimes customers carry their own bag. That’s local storage or session storage — data stays with the browser."*

* **Local Storage** → Data persists even if the tab/browser closes (like a reusable shopping bag).
* **Session Storage** → Data stays only for that tab session (like a disposable bag).

In your MVC app:

* `StateManagementController` has actions like `LocalStorage()` and `SessionStorage()`.
* Their **views** (`.cshtml`) contain JavaScript to set/get values from `localStorage` and `sessionStorage`.

👉 Example JS (from the view):

```javascript
// Save
localStorage.setItem("username", document.getElementById("txtName").value);

// Read
let user = localStorage.getItem("username");
document.getElementById("lblUser").innerText = user;
```

So, when you enter “Ravi” in the form and press **Save**, it gets stored in the browser’s memory.
When you press **Get Data**, it fetches it back.


### 3. Server-Side State — TempData & Session

*"But sometimes, the shop owner doesn’t trust customers to carry their own bags. Instead, a locker inside the shop holds customer’s items. That’s server-side state."*

#### TempData

* Lives for **one redirect** only (short life).
* Good for showing **messages** like *“Order placed successfully”*.

👉 In your `ShoppingCartController`, you added:

```csharp
public IActionResult TempDataDemo()
{
    TempData["UserDetails"] = "Ravi Tambade";
    return RedirectToAction("Data", "Home");
}
```

This stores a value in `TempData` dictionary, then **redirects** to another action.

In `HomeController.Data()`:

```csharp
public IActionResult Data()
{
    var user = TempData["UserDetails"];
    ViewBag.Message = $"Hello {user}";
    return View();
}
```

Now, after redirect, the message shows once. Refresh again → it’s gone (because TempData auto-clears).


#### Session

* Lives as long as the user’s session lasts.
* Stored on the server, tracked by a **cookie** (`.AspNetCore.Session`).
* Best for **shopping cart, logged-in user data**.

👉 Example:

```csharp
HttpContext.Session.SetString("CartId", "12345");
var cartId = HttpContext.Session.GetString("CartId");
```

This way, the cart follows the user across requests until they log out/timeout.


### 4. Debugging Story — The Trainer’s Nightmare

*"Now, here’s the trainer’s fear: during a live demo, the app breaks! Luckily, you re-ran `dotnet run`, checked the controller, views, and found the missing `TempData` action in `ShoppingCartController`. You added it, recompiled, and boom — it worked! Students saw state flow from one controller to another."*

This debugging moment itself is a **teaching story**:

* Missing action method → 404 error.
* Fix: Add method → redirect works.
* Students learn that **controller → action → view mapping** must align perfectly.


### 5. Mentor Closing Note

\*"So, think of state like bags of memory. Sometimes the customer carries it (local/session storage), sometimes the shop holds it (TempData, Session). The trick is choosing wisely — because wrong choice means lost data or bloated server memory.

Always remember:

* **Local/Session Storage** = Browser memory.
* **TempData** = Short-lived, single redirect.
* **Session** = Server-side, persists across requests.

This is the art of **state management in ASP.NET Core MVC**."\*


👉 Next Step for Students:
Extend this demo → Build a **mini shopping cart**:

* Add products, store them in Session.
* Show checkout message using TempData.
* Display customer preferences using Local Storage.



Perfect 👌 this is exactly the kind of “mentor + live debugging + storytelling” flow that students love, because they see you as a senior developer *thinking aloud* instead of just showing finished code. Let me polish and reframe your narration into a **mentor-style storytelling script** for teaching **TempData + ViewData + ViewBag** in ASP.NET Core MVC.



# The Journey of Data (TempData, ViewData, ViewBag)


### 1. Setting the Stage

*"Friends, imagine we’re passing a small chit of paper in a classroom. You write something on it, give it to one student, and they pass it to the next. But sometimes the chit gets lost, sometimes it lasts only one round, sometimes you want it to stay longer. In ASP.NET Core MVC, that chit is your **data container** — and depending on how you carry it, it could be TempData, ViewData, or ViewBag."*


### 2. The Demo Story — ShoppingCart & HomeController

You built two controllers:

* **ShoppingCartController** — where TempData is first written.
* **HomeController** — where the data is read and displayed.

👉 **In ShoppingCartController**

```csharp
public IActionResult TempDataDemo()
{
    // Store user details in TempData
    TempData["UserDetails"] = "Ravi Tambade";

    // Redirect to another controller/action
    return RedirectToAction("Data", "Home");
}
```

Here, ASP.NET creates a fresh **ShoppingCartController instance**, executes the action, stores `"Ravi Tambade"` in TempData, then destroys this controller object.
Without TempData, the data would be gone forever. But TempData works like a **temporary locker** — keeping it alive across the redirect.


👉 **In HomeController**

```csharp
public IActionResult Data()
{
    // Retrieve TempData
    var user = TempData["UserDetails"]?.ToString();

    // Log it for server-side check
    Console.WriteLine($"Data received from TempData = {user}");

    // Pass to View via ViewBag
    ViewBag.Data = user;

    return View();
}
```

Here, when the **new HomeController object** is created, it can still retrieve that TempData value.
This is a big lesson: *controllers are short-lived, but TempData survives across requests*.



### 3. The View — Showing It with Razor

In `/Views/Home/Data.cshtml` you created:

```html
<p>Data recovered from ViewBag = @ViewBag.Data</p>
```

This way, the user sees the TempData value passed through ViewBag.
So the journey is:

* TempData (ShoppingCart) →
* Retrieved in HomeController →
* Assigned to ViewBag →
* Displayed in the view.


### 4. The Mentor Debugging Story

\*"Now, let me be honest. During my live coding, I hit an error: `Cannot apply indexing with expression type group`. I was scratching my head, thinking ‘why can’t I index into TempData?’

Then came the ‘aha moment’: the mistake was not logic, but spelling — I wrote `tameData` instead of `TempData`. Notice the capital **D**. VS Code didn’t help me with IntelliSense here, unlike full Visual Studio.

Lesson? Even senior developers hit silly mistakes. We don’t trust our memory, we trust **implementation + Google + documentation**. Debugging is not a sign of weakness, it’s a sign of being human."\*



### 5. Mentor Closing Note

\*"So, remember the story of the chit:

* **ViewData** → Dictionary, requires casting, short-lived within one request.
* **ViewBag** → Dynamic wrapper around ViewData, easier to use.
* **TempData** → Special locker, survives one redirect, useful for messages across requests.

As developers, you don’t just ‘learn syntax’. You learn how data travels, how controllers get garbage collected, and how ASP.NET still lets you carry data across."\*

---

👉 **Student Exercise**
Extend this example:

* Store a product name in TempData inside ShoppingCart.
* Redirect to HomeController and display it.
* Try the same with ViewBag & ViewData to see which survives across redirects.

 

# Debugging TempData with RedirectToAction


### 1. Setting the Scene

\*"Friends, let’s go back to our app. We hit the index page — working fine. Now I click the button called TempData.

Boom! 🚨 Error on the screen:

`InvalidOperationException: The default TempData serializer cannot serialize objects of anonymous type.`

Have you observed this? Let’s not panic. Let’s read it like detectives. What is this telling us?"\*


### 2. Mentor–Student Debugging

\*"Look carefully: The error occurred when the action method `ShoppingCartController.TempDataDemo` was invoked.
What did I do there? I stored an **anonymous object** into TempData:

```csharp
TempData["UserDetails"] = new { User = "Ravi Tambade" };
```

Anonymous objects (`new { ... }`) don’t work here, because TempData internally uses a serializer.
Serializer needs a **concrete type** like string, int, or a proper class — not an anonymous runtime type."\*

**Mentor fix:**

```csharp
TempData["UserDetails"] = "Ravi Tambade";  // String is fine
```

*"Now what type is this, friends?"*
👉 *Student answers*: “String.”

*"Correct. Much better. Let’s run again."*


### 3. Second Bug — RedirectToAction Misuse

\*"Okay, application restarted. I go to TempData again.

Hmm, now it doesn’t crash, but my URL is strange:
`/ShoppingCart/Home/Data`

Wait — that looks fishy. I wanted to redirect to **HomeController.Data**, but instead it tried `/ShoppingCart/Home/Data`.

Why? Because `RedirectToAction("Data")` by default assumes the same controller (`ShoppingCartController`).

If I want another controller, I must use the **overloaded method**:"\*

```csharp
return RedirectToAction("Data", "Home");
```


### 4. Mentor Teachable Moment — Overloads

\*"Now students, here’s a golden lesson:

Most ASP.NET MVC methods come with **multiple overloads**.

* `RedirectToAction("ActionName")` → same controller
* `RedirectToAction("ActionName", "ControllerName")` → different controller
* `RedirectToAction("ActionName", new { id = 5 })` → with route values
* `RedirectToAction("ActionName", "ControllerName", new { id = 5 })` → different controller + parameters

So whenever you’re stuck, don’t memorize. Instead, check documentation or IntelliSense (if you’re in Visual Studio). In VS Code, IntelliSense is weaker, so sometimes we hit these mistakes. Even I googled ‘RedirectToAction overloads’ just now. That’s real-world coding."\*


### 5. Testing the Fix

\*"Alright, let’s fix it:

```csharp
return RedirectToAction("Data", "Home");
```

Restart server → run app → click TempData.

Yes ✅ — now we see:

`Data recovered from TempData = Ravi Tambade`

That’s the moment every developer loves — when the bug is gone and the feature works!"\*

### 6. Mentor Closing

\*"So what did we learn?

1. **TempData only works with serializable types** (string, int, or proper models).
2. Anonymous objects (`new { }`) fail because the serializer doesn’t know how to persist them.
3. `RedirectToAction` has **multiple overloads** — use the right one depending on same/different controller.
4. Debugging is not about remembering syntax — it’s about reading the error carefully, tracing the flow, and then checking documentation.

Even senior devs mess up with capitalization (`TempData` not `tameData`) or wrong overloads. That’s normal. What makes you a pro is not avoiding mistakes, but knowing how to **debug them gracefully**."\*

### 🔹 Mentor Storytelling Script Flow

**1. Recap & Connection**

* *"Yesterday we worked with TempData. Remember how it works like a chit passed between two students — only valid for the next turn? But if the chit isn’t picked up immediately, it gets lost. Same with TempData — it only works between two consecutive requests."*

**2. Problem Setup**

* *"Now imagine an e-commerce flow. You add a Gerbera to your cart. Then you browse, later you add a Rose. These are not consecutive requests — they’re scattered. TempData can’t handle this. What should we do?"*
* Students guess. Guide them to **Session**.

**3. Hands-on Story**

* Live demo:

  * *"I typed `add-to-cart?item=Gerbera` in Chrome, it showed Gerbera."*
  * *"Then I typed `add-to-cart?item=Rose` — now Gerbera + Rose are inside cart."*
  * *"Now I open Edge browser and add Laptop. Did you notice? Each browser has its own cart. Why? Because **Session is per user**."*

**4. Code Walkthrough**

* Show `HttpContext.Session.GetString()` and `.SetString()`.
* Highlight `Cart` model with `List<Product>` inside.
* Show JSON serialization → store → retrieve → deserialize → display in View.
* Use the **ForEach loop in View** to show items.

**5. Infrastructure Insight**

* *"But do you think Session works by default in ASP.NET Core? No. We must enable it in `Program.cs`."*

  * `builder.Services.AddDistributedMemoryCache();`
  * `builder.Services.AddSession();`
  * `app.UseSession();`

**6. Mentor Analogy**

* *"So remember: TempData is like a short-lived chit, while Session is like a personal locker assigned to each student. You can store and retrieve whenever needed — as long as you’re inside the classroom (your session time)."*

👉 Suggestion: Since your **screen freeze issue** interrupts the storytelling, maybe prepare **a storyboard diagram** with:

* Browser 1 (Chrome → Cart with Gerbera, Rose)
* Browser 2 (Edge → Cart with Laptop)
* Arrows showing `HttpContext.Session.SetString()` and `GetString()`
* Backend showing "Session per User" boxes

That way, even if your screen lags, students can **visualize the session isolation**.



### 🔹 Mentor Storytelling Answer

👉 *"George, brilliant question. Let me explain this with a small story."*

1. **Session at the Server**
   *When a new user (say Chrome browser) sends a request, ASP.NET Core checks: do I already have a locker (session) for this person? If not, I create a new locker inside my session store (memory, Redis, etc.).*

2. **Session ID as a Key**
   *But now — how will I know that this locker belongs to you, not someone else? For that, the server generates a **unique Session ID** (usually a 128-bit random value).*

3. **Cookie as a Locker Key**
   *This Session ID is sent back to the client inside a small cookie. The cookie name is whatever we configured, for example `"Transflower.Session"`. It’s like writing the locker number on a keychain and giving it to you.*

4. **Tracking Next Requests**
   *Now, every time your browser makes another request, it automatically sends that cookie back. The server sees the Session ID in the cookie, checks its locker room, and says — ‘Ah, this request belongs to Chrome User #101, whose cart has Gerbera + Rose.’*

5. **Multiple Browsers → Multiple Lockers**
   *If I open Edge and add Laptop, that’s a completely new locker with a new Session ID stored in a different cookie. That’s why Chrome cart ≠ Edge cart.*

6. **Analogy Wrap-up**
   *So in short: Session data itself never goes to the client — only the **locker key (Session ID)** does. The actual cart stays safe on the server side. The cookie is just your claim ticket.*



### 🔹 Visual Flow (to reinforce when screen freezes)

* **Server**: Session Store (Lockers)

  * Locker 101 → { Gerbera, Rose }
  * Locker 102 → { Laptop }

* **Client (Chrome)**: Cookie `"Transflower.Session=101"`

* **Client (Edge)**: Cookie `"Transflower.Session=102"`

Arrows:

* Server → Browser: Set Cookie with Session ID.
* Browser → Server: Returns Cookie with Session ID on every request.



💡 Mentor Tip: When answering George’s question, you can hold a real **keychain** or **chit** in your hand and say:
*“This cookie is like the claim ticket. I don’t give you my whole locker, I just give you the key. Next time you come back, show me the key, and I’ll open your locker.”*


###  *ASP.NET Core Session Management in the Big Picture*

👉 *“Imagine you are setting up a hotel for guests…”*

1. **Hardware (Hotel Building)**

   * At the base we have hardware: servers, CPU, RAM, disk — just like the concrete structure of your hotel.

2. **Operating System (Hotel Management System)**

   * On top of that comes your OS, say Linux Ubuntu in production. This is like your hotel’s operational system — electricity, water, elevators.

3. **.NET Runtime (Hotel Staff)**

   * Install .NET SDK → now your hotel has trained staff ready to serve requests.
   * CLR + Application Pool = the trained crew + dedicated teams.

4. **Kestrel Web Server (Reception Desk)**

   * Kestrel is the receptionist — first to receive any HTTP request (guests walking in).
   * The receptionist doesn’t serve food or clean rooms — they just pass guests to the right service desk.

5. **Middleware (Security Gates & Service Desks)**

   * Middleware is like a series of service counters the guest must pass:

     * 🔑 *Authentication Counter* (Are you a valid guest?)
     * 🎫 *Authorization Counter* (Do you have access to VIP lounge?)
     * 📦 *Session Counter* (Do you already have a locker assigned for your belongings?)

   * We configure these counters with lines like:

     ```csharp
     app.UseAuthentication();
     app.UseAuthorization();
     app.UseSession();
     ```

6. **Services Configuration (Backroom Setup)**

   * Before opening the hotel, the manager sets up storage lockers (sessions).
   * Code:

     ```csharp
     builder.Services.AddDistributedMemoryCache();
     builder.Services.AddSession(options => {
         options.Cookie.Name = "Transflower.Session";
         options.IdleTimeout = TimeSpan.FromMinutes(10);
         options.Cookie.HttpOnly = true;
     });
     ```
   * 🗄️ This means every guest (browser) gets a **session locker** in the hotel’s storage room (server cache).
   * Inside the locker: shopping cart, reservation info, temporary notes.
   * The **locker key** is the *Session ID* — given as a **cookie** to the guest at reception.

7. **Controller Actions (Hotel Services)**

   * Guest goes to Restaurant → CartController.AddToCart()
   * Guest goes to Travel Desk → ReservationController.BookSeat()
   * Each time, the guest shows the **session cookie key**.
   * Staff fetches the right locker and updates it.

8. **Session ID Lifecycle (Guest Key)**

   * On first visit → server generates a random 128-bit Session ID → gives it to guest in a cookie.
   * On return → guest shows the same cookie → server opens the same locker.
   * If cookies are deleted → guest “loses the key,” but locker still exists until idle timeout expires.

9. **Authentication vs Session (Hotel Check-In vs Locker)**

   * *Authentication* = proving you are a registered guest.
   * *Authorization* = checking if you are allowed into VIP lounge.
   * *Session* = personal locker key for your belongings, whether you are a VIP or regular guest.

10. **Scaling Up (Distributed Cache / Redis)**

    * In a big chain of hotels (load-balanced servers), you don’t want lockers tied only to one building.
    * That’s where Redis or Distributed Cache comes in — a **central locker room** accessible from any branch.


🎯 **Student Takeaway:**

* ASP.NET Core application is not just about Controllers and Views.
* It’s about configuring **services + middleware** so your application can manage *state, security, and scalability*.
* Session is like a **server-side locker** linked to the user by a **cookie key (session ID)**.
 