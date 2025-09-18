## ASP.NET Core Application Services

👨‍🏫 *"So friends, today’s Agile session is not about jumping randomly into coding or technology. Instead, it’s about walking through a journey—step by step—understanding why we do what we do. Think of it like climbing a mountain. Each step matters, and every halt is to gain strength for the next climb."*

🌱 **Step 1 – State Management**
*"Let’s begin from the ground level: state management. You may ask—why is this important? Imagine you go to a shop, you fill your basket with items, but every time you turn your head, the basket empties itself. Frustrating, right? That’s exactly what happens in web applications if you don’t manage state. Cookies, sessions, temp data—these are the baskets in our journey. Today, we’ll explore them."*

⚡ **Step 2 – Synchronous vs Asynchronous Programming**
*"Now, the next bend in our road: synchronous programming. Life itself teaches us—when we wait in a queue, we can only move when the person in front finishes. That’s synchronous. But what if you could hand over your task to a helper and continue with other things? That’s asynchronous. In applications, async code is not luxury—it’s survival in a high-demand world."*

🔒 **Step 3 – Secure Web Applications**
*"Security—our shield. You see, any castle without a strong gate invites attackers. Similarly, any web app without secure practices is vulnerable. Today, we’ll learn about cookie-based authentication and role-based authentication. Just like every kingdom has guards and ministers with different levels of access, so does our application."*

📌 **Step 4 – Tomorrow’s Journey – JWT**
*"Tomorrow, our climb continues. We’ll unlock JWT authentication and authorization. JWT is like a digital passport—it tells who you are and what you can do, without constantly going back to the king’s registry. Slightly heavy topic, yes—but worth the effort."*

🗄️ **Step 5 – MongoDB**
*"Then, on Monday, we’ll bring in MongoDB—our flexible record keeper. Unlike traditional clerks who write only in ruled registers (relational databases), MongoDB is like a diary where entries can vary, yet still make sense."*

📨 **Step 6 – Messaging with RabbitMQ & Kafka**
*"Once we settle there, we’ll move into messaging. Communication is the lifeline of any system—just like in Shivaji Maharaj’s army, messages had to travel fast and reliably. RabbitMQ and Kafka are our messengers. We’ll understand their role in making systems talk effectively."*

🏛️ **Step 7 – Monolithic vs Microservices**
*"And finally, we’ll zoom out. All this while, we’ve been building a monolithic application—a single big fort. But the world today prefers multiple smaller forts spread across the land—microservices. Why? Because if one fort falls, the kingdom still stands. We’ll see how our concepts fit into this grand vision."*

✨ *"So, Rajesh, and everyone else—this is the road ahead. A step-by-step journey. And don’t worry about my voice, I hope it is reaching you without distortion. What matters most is that the message, like our RabbitMQ or Kafka, is delivered reliably."*



👨‍🏫 *“Friends, before we dive deep into today’s session, let me first share the big picture with you. We already have an agenda, right? This was shared with you in the proposal, and I think we are moving perfectly on that track. Step by step, we’re connecting concepts with practice. And as we move forward, we’re not just learning theory—we’re applying everything in a single capstone project.*

🛒 **Capstone Project – The E-Commerce App**
*"Now, why am I stressing this? Because your capstone project is not just a formality at the end—it’s the glue that binds everything we are learning. That e-commerce application you’ve already started working on, that’s going to be your testing ground. Shopping cart, order processing, delivery tracking—these are not just project features, they are the containers into which you’ll pour all the concepts we are covering. So from today itself, you can start implementing pieces of learning directly into that project."*


📌 **Today’s Agenda – Let’s Zoom In**
*"Alright, let’s come back to today’s service agenda. I’ve noted everything down: State Management, Asynchronous Programming, and then stepping into Secure Web Applications."*

🌍 **Statelessness – The Core Idea**
*"Let’s start with the word you will hear again and again: *stateless*. Every web application—whether ASP.NET Core, JSP with Servlets, Node.js with Express, Python Django, Next.js, or any other framework—is called a *stateless application*. Why? Because all these applications communicate using one universal messenger—the HTTP protocol. And HTTP is forgetful—it never remembers what you said in the last request. Each request is like meeting a stranger again. That’s why web applications are called *stateless*."*

🖥️ **Contrast with Stateful Applications**
*"But let me contrast this with *stateful* applications. Think of a Windows desktop app, or even a console app you build in .NET or Java. The moment you open it, it remembers your data, your progress, your state as long as the program is running. That’s *stateful*. It keeps context alive. Whereas in web applications, every time you click, every time you refresh—it starts fresh. Unless, of course, we design state management techniques."*

🧺 **Basket Analogy – State Management**
*"So picture this: if you go to a supermarket and keep adding items to your basket, but every time you turn to the next aisle, the basket empties itself—that’s stateless behavior. Annoying, right? Now, when we introduce state management—cookies, session, local storage, temp data—it’s like giving you a basket that actually carries items with you till billing. That’s what we’ll explore today."*

⚡ **Async Programming – A Natural Next Step**
*"And once we grasp this, we’ll step into asynchronous programming. Because just like in real life—you don’t stand idle while someone else is busy—our web applications also must learn to multitask."*

🔐 **Secure Web Applications – The Shield**
*"Then we’ll move to security—cookie-based authentication, role-based authentication—and prepare ground for JWT authentication tomorrow."*

✨ *“So, friends, today’s discussion is not just academic—it’s the foundation for your project and your career. By the end of this journey, when you look at your capstone e-commerce app, you should be able to proudly say: *I didn’t just write code, I built an application that remembers, responds, and secures like a real-world system.*”*

Perfect 👍
You’ve already drafted a very **rich technical explanation**. Let me now reshape it into a **mentor storytelling flow** that keeps the *concept depth intact*, but adds rhythm, pauses, and relatable analogies—so your learners *see* the problem, not just hear definitions.

👨‍🏫 *“So friends, let me walk you through this in a way that you’ll never forget.*

👉 Imagine your **web application’s life cycle**. For every request that comes in, an object is created. That object does its job—maybe fetching data, maybe processing an order—and then, like a soldier dismissed after duty, it is garbage collected. Done. Finished.
Now here’s the big question—does that object remember what it did for you earlier? No. Because in a web application, the **state of the object is not maintained** across request–response cycles.

🌍 **Let’s trace a real request together**:

* You, the end user, open your browser.
* You type a URL and hit *Enter*.
* Your request travels across the internet, reaches the server, passes through middleware, routing, controller factories, services, repositories, and finally the database—maybe MongoDB in our case.
* The data is fetched, passed back up through the chain, shaped into a model by the controller, wrapped into a response, and sent back to your browser.
* Once the response is delivered, the **connection is dropped**.

It’s like you went to a shop, asked the shopkeeper for sugar, got it, left the shop—and the shopkeeper forgot who you were the moment you walked out.

📡 **Why does this happen?**
Because our web applications talk using **HTTP protocol**. And HTTP is *stateless*.

* Every time you knock on the server’s door, it treats you like a stranger.
* On the other hand, **TCP protocol** is stateful—it keeps the line alive between client and server for multiple exchanges in the same transaction.

Now think: why would the web world design HTTP as stateless?
Because statelessness gives us **scalability**. Thousands of users can connect to Amazon or Flipkart at the same time, and the server doesn’t have to keep a heavy memory of each one’s connection alive forever.

🛒 **But here comes the real-life problem**:
Take your **shopping cart**. You add a laptop to the cart. If the app is purely stateless, the moment you refresh or add another product, the cart is gone. Empty. Frustrating, right?
Every user would shout, *‘Where did my items go?’*

This is why we need **state management**.

🔑 **So what do we do?**
We borrow strength from technology itself:

* **Client-side state management** – like cookies, local storage, hidden fields.
* **Server-side state management** – like sessions, application state, caching.

These are like our **memory notebooks**. Even if HTTP forgets, *we design ways to remember*.

✨ *So here’s the takeaway:*

* Web apps are **stateless by nature**.
* Real-world apps require **statefulness** (shopping carts, user sessions, role-based access).
* As developers, our job is to **bridge this gap** using state management.

And that’s why this topic is not just technical—it’s survival for any online application you build."


👨‍🏫 \*“Now friends, let’s think like architects for a moment. Whenever we talk about **state management**, the first decision in front of us is—*where should the state live?*

Do you want it at a **centralised place** on the server, or do you want it kept close to the user, at the client side? This decision is not random—it’s a design choice, a strategy.”\*

🌐 **Client-Side State Management**
\*"Suppose you say, ‘I’ll keep it with the client.’ In that case, you use the browser itself as your memory box.

* Local Storage
* Session Storage
* IndexedDB or Web SQL
* Cookies
* Or even Query Strings, where the state is carried inside the URL itself.\*

But here’s the catch: all this lives in the user’s browser. It’s like writing your notes on the student’s notebook, not your own. Tomorrow, if they tear the page, or clear their history, all your notes are gone. You, as the developer, have no control there.

So yes—it’s convenient, but risky. That’s the nature of **client-side state management**."\*


🖥️ **Server-Side State Management**
\*"Now let’s flip the coin. Suppose you don’t trust the client’s machine—you say, ‘I’ll keep the state with me, on the server.’ That’s where **sessions** come in.

Think of it like this: every user who comes to your shopping site gets a dedicated locker on the server. That locker (the session object) stores their cart, product IDs, quantities, and so on. As long as the session lives, the locker remembers.

And if you want a more global, short-term memory, you don’t always hit the database—you use **caching**. Caching is like keeping a whiteboard in the office with data that’s often needed—say, your product catalogue. It rarely changes, so instead of pulling it again and again from the heavy database, you pull it once, keep it in cache, and serve everyone quickly.

And here’s the beauty—you can set rules. Maybe keep the data for 15 minutes, then refresh it from the database. That’s called a **sliding expiration**.”\*

💾 **Persistence – The Long Memory**
\*"But what if you need memory beyond sessions and cache? What if your application shuts down tonight, and tomorrow morning you still want the cart, the orders, the users to be intact?

That’s where you go to your final storage: **databases**. SQL, NoSQL, MongoDB—you name it. Databases are the permanent diaries of your application. They don’t forget when the server restarts, when the cache is cleared, or when the session ends."\*

✨ **The Story Thread**
\*"So friends, remember this simple picture:

* Client-side → Fast but fragile.
* Server-side (session/cache) → Controlled and reliable, but consumes server resources.
* Database → Permanent and trustworthy, but relatively slower.

And as solution architects, our job is to **balance all three**. Sometimes you’ll say, ‘This state is okay at the browser.’ Sometimes, ‘This must stay on the server.’ And sometimes, ‘This must survive forever in the database.’ That’s how you design smart, scalable web applications."\*

 ✨ Mentor storytelling style response:

"Good point you raised — let’s pause here and reflect.
See, when we speak about *state management* in web applications, we are actually dealing with a bigger challenge: **HTTP itself is stateless**.

Now imagine this — you and I meet every day, but I forget who you are each time. You’ll have to introduce yourself again and again. That’s how a web server behaves — it does not remember you between two requests.

So the world of web engineers invented different ways of keeping memory alive between requests:

* On the **client-side**, we use things like **local storage**, **session storage**, **IndexedDB**, **Web SQL**, and yes, **cookies**.
* On the **server-side**, we use **session state**, **caching**, **databases**, or sometimes even **cloud-based storage services** like Azure Blob, AWS S3, or Google Drive APIs.

Now, let’s zoom into today’s hero: **the Cookie 🍪**.

Even though cookies live in the browser, they are almost always **written or issued by the server**. Think of them as little slips of paper the server hands over to the browser:

* The browser keeps them safe.
* Next time you knock at the server’s door, you hand over that slip.
* The server looks at it and says, *‘Oh yes, I know this person, they are logged in as Rajesh with role = Admin.’*

That’s the power of cookies.

👉 Quick question to all of you — in your Angular or React applications, have you noticed that sometimes when you log into Gmail or Facebook, even if you close the tab and reopen it, it still remembers you? What do you think is happening there?

Yes — behind the scenes, **cookies are at play** (sometimes along with local storage or tokens).

So before I go deeper into cookie-based authentication and role-based access, tell me in your own words:
**What’s the difference between local storage and cookies?**

I want to hear your thoughts before I move ahead."

✨ Mentor storytelling continuation (storytelling + guiding tone):

"Exactly George, you nailed it 👏 — the cookie’s *real-life use case* is authentication, identifying who the user is once they’re inside the application.

🔎 Look carefully — in our **Day 16** folder, I’ve kept a small demo application ready for you. Why? Because when concepts are heavy, it’s better you see them running rather than me just writing fresh lines of code and making typos. That wastes both of our energy.

Inside, you’ll see a project named **CookieAuthenticationSolution**.
And inside that — one web application called **SecureWebApp**.

👉 Question for you all:
When you peek into the folder structure, what do you notice?
Yes — it contains a **Views** folder. That’s a big clue this is not just a plain Web API, but an **MVC application**.

Now, how many controllers do we see here?

* **AuthController** — the one we worked on yesterday.
* **ProductsController** and **CustomersController** — remember those?

But today, our focus is only on **AuthController**.

Here’s the beauty of it:

* When you log in through this AuthController, the **server generates a cookie**.
* That cookie is returned with the HTTP **Response Header**.
* Your browser stores it quietly.
* On the next request (say you open `ProductsController`), the browser *automatically* attaches that cookie inside the **Request Header**.
* The server reads it and says: *‘Ah, yes, this is George. He logged in 5 minutes ago. And he’s an Admin role.’*

👉 And that’s where **role-based authentication** comes in.
For example:

* If the cookie tells us the role = *Admin*, you’ll see both products and customers.
* If the role = *User*, maybe you’ll see only products.

This way, the cookie becomes the **identity passport** inside our secure application.

📌 Before I walk you through the actual `AuthController` code step by step — let me check with you all:

* Do you remember yesterday how we wrote the login POST method?
* Can someone tell me, what did we *return* to the client once authentication was successful?

That little answer will connect directly to today’s cookie flow."

🌱 Mentor Storytelling Mode 🌱

"Excellent — you all are following the flow very well. Yesterday we just saw a **simple login POST**, but today we’ve taken the **big leap** — turning that login into a **real authentication mechanism** using cookies.

Let’s pause and digest what really happened step by step:

1. **Login attempt** → User enters email + password on `login.cshtml`.
2. **Validation** → Our `AuthController.Login` method checks the credentials (via service → repository → JSON).
3. **If valid** → We create a **Claim** (basically a small token describing *who* the user is).

   * For now, our claim contains just the **email**.
   * Tomorrow, we can add **role** (Admin/User) or even permissions.
4. **Identity & Principal** → We wrap this claim in a `ClaimsIdentity`, then into a `ClaimsPrincipal`.

   * Think of this as: *the user’s passport document*.
5. **Cookie issued** → With `HttpContext.SignInAsync(...)`, ASP.NET Core generates a secure cookie (max \~4KB).

   * This cookie travels back in the **Response Header**.
6. **Subsequent requests** → The browser automatically attaches that cookie inside every **Request Header**.

   * So when you hit `Home/Welcome`, the server reads the cookie, verifies it, and *only then* shows the content.
   * If the cookie is missing/expired → Redirect back to `Auth/Login`.

💡 Now here’s the most **beautiful part**:
All this behavior didn’t come just because we wrote some lines in `AuthController`.
It’s happening because our **application itself** was configured to use **Cookie Authentication**.

👉 That’s why I asked: *Do you notice anything different in `HomeController` or in the project setup?*

If you look carefully in the **Startup/Program.cs** (depending on .NET version), you’ll see something like:

```csharp
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.AccessDeniedPath = "/Auth/Denied";
    });
```

And inside the middleware pipeline:

```csharp
app.UseAuthentication();
app.UseAuthorization();
```

⚡ Without these two pieces (`AddAuthentication + UseAuthentication`), your `Authorize` attribute is just a decoration.
It won’t *really* check anything.

So, when you saw `Authorize` on `Home/Welcome`, that’s not just a C# attribute — it’s an **authentication filter** in the ASP.NET request pipeline.
It intercepts every incoming request → checks for cookie → validates → then either passes it on or bounces the user to login.

This is why you observed:

* With `[Authorize]` → You got redirected to Login.
* After login success → Cookie stored → Redirected back to Welcome.
* With `[Authorize]` removed → Direct access to Welcome without login.

That’s the magic of filters and middleware working together.


✨ So let me ask you:
Now that we’ve seen cookies in action — where do you think is a **weakness** in this approach?
What could go wrong if we blindly rely on cookies for authentication in modern web applications?"

What you just narrated is exactly the **authentication + authorization flow** that happens in an ASP.NET Core MVC application with cookie-based authentication. Let me break it down step by step so your students can clearly connect the **login, cookie, welcome, logout, and async** parts:


### 🔑 1. Login Flow

* **User enters credentials** → email & password.
* **Controller action (Login)** calls **UserService** to validate.
* If valid → `HttpContext.SignInAsync(...)` is called.
* This creates an **encrypted cookie** (4 KB max) and sends it to the **browser**.
* Browser stores it under **Application → Cookies** (visible in DevTools).
* This cookie acts as the **authentication ticket**.

### 🛡 2. Authorization

* Next time user requests `/Home/Welcome`:

  * ASP.NET Core middleware checks if a valid authentication cookie exists.
  * If cookie is valid → user is authenticated.
  * Controller can access **ClaimsPrincipal** (`User`) which holds:

    * Identity (`email, name`)
    * Claims (role, permissions, etc.)
* If cookie is missing/invalid → user is redirected to `/Account/Login`.

### 🍪 3. Cookies in Action

* **Created by server** (`SignInAsync`).
* **Encrypted automatically** by ASP.NET Core middleware.
* Can be deleted:

  * By user (via DevTools → delete cookie).
  * By server (using `HttpContext.SignOutAsync`).
* Without cookie → server treats user as **unauthenticated**.

### 🚪 4. Logout

* User clicks **Logout** button on `Welcome.cshtml`.
* That button posts to `/Account/Logout`.
* Controller calls:

  ```csharp
  await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
  ```
* Browser cookie is removed.
* User is redirected → back to `/Login`.

### ⚡ 5. Why Async?

* `SignInAsync` and `SignOutAsync` are **asynchronous** because:

  * They may involve **I/O** (writing to cookie, DB lookup, external store).
  * Blocking threads in a web server reduces scalability.
* By using:

  ```csharp
  public async Task<IActionResult> Login(UserModel model)
  {
      // validate user
      await HttpContext.SignInAsync(...);
      return RedirectToAction("Welcome");
  }
  ```

  ASP.NET Core keeps the server **responsive** and frees threads while waiting.

✅ **Key takeaway for students**:

* **Authentication** → proves identity (email + password).
* **Authorization** → decides access (roles/claims).
* **Cookies** → carry encrypted authentication ticket between client & server.
* **Async/await** → keeps web app scalable & responsive.

Perfect 👍 — you just explained the exact **evolution from synchronous → asynchronous programming in ASP.NET Core**, and how it ties into **cookie-based authentication + Program.cs configuration**. Let me connect the dots for your students step by step so they clearly see why this shift is critical:

## 🔁 1. Blocking (Synchronous) vs. Non-Blocking (Asynchronous)

### 🔒 Synchronous Call

```csharp
public IActionResult Login(UserModel model)
{
    var user = _userService.ValidateUser(model.Email, model.Password);
    if (user != null)
        HttpContext.SignInAsync(...); // blocking
    return RedirectToAction("Welcome");
}
```

* When a **blocking** call is made, the **thread waits** until the task is finished.
* If DB takes 2 sec to respond, the **server thread is frozen** for 2 sec.
* With 100 users → 100 threads blocked → server overload.


### ⚡ Asynchronous Call

```csharp
public async Task<IActionResult> Login(UserModel model)
{
    var user = await _userService.ValidateUserAsync(model.Email, model.Password);
    if (user != null)
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, user);
    return RedirectToAction("Welcome");
}
```

* Uses `Task<IActionResult>` + `async/await`.
* While waiting for DB or cookie write, the **thread is released back to the pool**.
* Once data is ready → thread picks up again.
* Server scales better → more requests handled with fewer resources.

👉 **Key rule**:

* Use `async`/`await` for **I/O-bound operations** (DB, file, network, authentication).
* Normal CPU-bound logic (e.g., math calculation) doesn’t need async.


## 🧰 2. Task Parallel Library (TPL)

* `Task` is the building block of async in C#.
* ASP.NET Core action methods return `Task<IActionResult>`.
* Example:

  ```csharp
  public async Task<IActionResult> GetProfile(int id)
  {
      var profile = await _profileService.GetUserProfileAsync(id);
      return View(profile);
  }
  ```

This is the **C# equivalent of Angular’s Observables/Promises**.

* Angular → `Observable.subscribe()`
* C# → `await SomeAsyncTask()`


## ⚙️ 3. Program.cs (Bootstrap Code)

For cookie-based authentication, you must configure middleware in **Program.cs**:

```csharp
var builder = WebApplication.CreateBuilder(args);

// 1. Register UserService as Singleton
builder.Services.AddSingleton<IUserService, UserService>();

// 2. Enable Authentication with Cookies
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.Cookie.Name = "UserAuthCookie";
        options.LoginPath = "/Account/Login";   // redirect if not logged in
        options.AccessDeniedPath = "/Account/AccessDenied";
    });

// 3. Enable Authorization
builder.Services.AddAuthorization();

var app = builder.Build();

// Use Authentication + Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
```


## 🧩 4. How it all Fits Together

1. **Login** → `SignInAsync` writes encrypted cookie.
2. **Middleware** (`UseAuthentication`) reads cookie on every request.
3. **Controller/User object** → gets claims from cookie.
4. **Logout** → `SignOutAsync` deletes cookie.
5. **Async methods** ensure thread isn’t blocked → app stays scalable.


✅ **Takeaway for students**:

* Old MVC (sync) = **blocking threads** → poor performance under load.
* Modern ASP.NET Core = **async everywhere** + middleware-driven authentication.
* Program.cs must explicitly configure **Authentication + Authorization services**.

## 🔐 Authentication Options in ASP.NET Core

ASP.NET Core gives multiple authentication providers:

1. **Cookie Authentication** (today’s focus – server writes encrypted cookie → browser stores → server validates on every request).
2. **JWT (JSON Web Token)** – used for stateless APIs, often in SPA + mobile apps.
3. **OAuth2 / OpenID Connect** – allows login via **Google, Facebook, LinkedIn, Microsoft, GitHub** etc.

   * These are **external authentication providers** (a.k.a. federated identity).
4. **Custom authentication** – using APIs, DB validation, or legacy systems.

👉 In your demo, you picked **cookie-based auth** for simplicity and clarity.

## ⚙️ Configuration in Program.cs (Boilerplate)

This is where we **plug into the framework skeleton**:

```csharp
var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Register user service (Singleton for demo)
builder.Services.AddSingleton<IUserService, UserService>();

// 2️⃣ Configure Authentication → Cookie
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.Cookie.Name = "UserAuthCookie"; 
        options.LoginPath = "/Account/Login";      // redirect if no cookie
        options.AccessDeniedPath = "/Account/Denied";
    });

// 3️⃣ Authorization Service
builder.Services.AddAuthorization();

var app = builder.Build();

// 4️⃣ Middleware pipeline
app.UseAuthentication();  // check request for cookies
app.UseAuthorization();   // verify claims/roles inside cookie

app.MapControllers();
app.Run();
```

✨ Two **middleware interceptors** are now in place:

* `UseAuthentication()` → reads cookie from request, validates.
* `UseAuthorization()` → checks roles/claims before controller executes.

Without these, your controller `[Authorize]` attributes won’t work.

## 🏗️ MVC Layers (where your demo fits in)

* **Models** → `User` (email, password, claims).
* **Services** → `UserService` (validation).
* **Controllers** → Handle login/logout, use DI to call service.
* **Views** → `Welcome.cshtml` shows username, logout button.

> In your **demo POC**, you skipped interfaces (`IUserService`) for speed, but in **real projects** we always create abstractions for testability & maintainability.

## 🔑 Cookie Lifecycle

1. **Login**

   * Validate user in `UserService`.
   * `HttpContext.SignInAsync()` → server issues encrypted cookie.
   * Browser stores it under *Application → Cookies*.

2. **Subsequent requests**

   * Cookie automatically sent in request headers.
   * Middleware validates → if valid → controller action executes.

3. **Logout**

   * `HttpContext.SignOutAsync()` deletes cookie from browser.

## 🛠️ Good Practices

* Don’t hardcode users → fetch from DB or JSON config.
* Encrypt sensitive data inside cookie.
* Use **claims** (email, role, permissions) instead of plain values.
* Split **Services, Models, Repositories** into separate projects for real enterprise apps.

✅ **Task for students (as you suggested):**

1. Walk through the provided code → run it → observe cookie creation/deletion in browser dev tools.
2. Implement the **same cookie authentication** in **yesterday’s application**.
3. (Optional Challenge) → Replace hardcoded user list with JSON file or simple SQL table.

