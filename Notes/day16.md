### 👨‍🏫 ASP.NET Core Views

“So yesterday, we were standing at the **gate of MVC controllers**, watching how a request travels. Do you remember?

👉 The browser sends a request → it passes through **middleware** → then through the **router** → then the **controller factory** → finally, your controller method is called.

Now, we didn’t stop there. We tried a small experiment with **form submission**.

* We said, when the form is submitted using **method=POST**, the request body carries your form data.
* Inside MVC, how do we capture it? Either by using `Request.Form` or by matching the **input `name` attributes** with the method parameters.

At that moment, I also reminded you about something:
🔖 These method markers like `[HttpGet]`, `[HttpPost]`, `[HttpPut]`, `[HttpDelete]` are nothing but **Action Filters**.

* In Angular, you call them *decorators*.
* In Java, you call them *annotations*.
* In C, you had *pragma*.
* In C#, we call them *attributes*.

That’s why when we wrote `[HttpPost] Login()`, it told MVC:
‘Hey, execute this method only if the request came via POST.’


Next, we peeked into the **Razor syntax**.
At first glance, Razor’s `@{ ... }` or `@Model` felt familiar, right? Almost like Angular template binding. That was not accidental — modern frameworks borrow these ideas from each other.

We also saw how to **redirect** with `RedirectToAction()`, how the controller can tell the browser:
‘Don’t stay here, go to another action method.’

📌 Then came the **special objects**:

* `ViewData` → Dictionary of key-value pairs.
* `ViewBag` → Dynamic wrapper, no type safety but quick to use.
* `TempData` → Survives for one request (or until read).

I told you, think of them as **different containers** in your kitchen.

* Sometimes you need a labeled jar (dictionary).
* Sometimes you want a flexible bag (dynamic).
* Sometimes you just pass something once and throw it away (temp).

And just like in `System.Collections.Generic` where we choose between `List<T>`, `Dictionary<K,V>`, or `HashSet<T>`, here too, ASP.NET Core gave us options.


🎯 Finally, I gave you a **homework**:

* Implement a **Register** functionality, just like Login, but with form submission, `[HttpPost]` action, and Razor view.
* I shared a **document** for guidance, expecting you to at least attempt it.

Because remember, my role is not just to show you the path but to make sure you walk a few steps on it.


👉 So today, before I move ahead, I want to know:

* Did you try the **Register functionality**?
* Did you face problems mapping form inputs with controller parameters?
* Or maybe you got stuck with **ViewData / ViewBag usage**?

Because the next lesson is waiting — but I don’t want to leave anyone behind at yesterday’s gate.”


### 👨‍🏫 Mentor Storytelling: Checking Register Homework

“Before we jump into today’s agenda, let’s quickly rewind.
Yesterday, I asked you to implement the **Register functionality** — a small extension of the Login flow.

👉 Now tell me honestly — how many of you actually tried it?
Can you raise your hand?
I see Rajesh, Shiv Sagar, and Arif have already attempted it — well done 👏.

But for the rest, I think either you didn’t get time or maybe got stuck. That’s okay.
If most of you haven’t tried, we won’t skip it. Instead, I’ll spend **15–20 minutes with you now** to write it together. Because unless you get your hands dirty with code, the concept remains half-baked.

📌 While checking your GitHub repositories last night, I noticed something interesting:

* Jitendra, you pushed some changes 9 minutes ago. I saw your **online shopping example**, where you created a `ProductsController`.
* You also started using **dependency injection** with `ProductService`, and passed data through **ViewData**. Good step forward 👌.
* But… I didn’t see an **Auth controller** in your repo. Did you skip the login/register part or is it in another branch?

So here’s my plan:

1. Let’s **quickly write the Register action method** inside `AuthController`.
2. Create a **Razor View** with a form (Name, Email, Password, Confirm Password).
3. Handle it with `[HttpPost] Register()` where form field names match parameters.
4. Finally, save the registered user into a simple in-memory list (for now).

This way, even if you missed it yesterday, you’ll leave today with working code in your GitHub.

👉 My question back to you all:
Would you like me to **live-code Register** with you right now (step by step), or do you prefer I just show you the **final solution** and we move ahead with today’s main agenda (Cookie Authentication + Middleware)?

### 👨‍🏫 Mentor Storytelling: Following Up on GitHub Progress

“Now let’s move beyond Jitendra’s work.
When I checked **Aravind Kumar’s repository**, I noticed something.

Yes, Aravind, you had made changes last week — around 5 days ago. That’s good, it shows you were keeping pace.
👉 But after that, there are no new updates.

Now I don’t know whether you:

* forgot to push your changes to GitHub,
* or maybe you didn’t get time to continue working,
* or perhaps you tried offline but never committed your work.

Whatever the case, I just want to highlight one important practice:

🚀 **Consistency matters more than speed.**
Even small incremental commits daily are better than waiting a week and pushing everything at once. Because GitHub is not just for me to track your work — it’s your personal diary of progress.

So Aravind, and for everyone else too, please make sure your repositories reflect your current learning. Don’t let them freeze at “last week.”

👉 Quick check: How many of you **worked locally but forgot to push** to GitHub?
If that’s the case, let’s make it a habit: *Code → Commit → Push* — daily, even if it’s just a small change.



### 👨‍🏫 Mentor Storytelling: Assessment through GitHub + Register Implementation

“Friends, I want to make one thing clear.
Our capstone project will happen, no doubt. But I don’t want that to be the *only* measure of your progress.

👉 From now on, your **GitHub repositories** will carry weight.
When I assess your learning, I will consider not just what you did in class, but what you have **published, committed, and pushed** into GitHub.

Why? Because GitHub is a mirror of your discipline. If there are no updates for weeks, it signals that you are not practicing consistently.

Now, I also know you all are working professionals. I don’t expect you to spend your office hours for this. That’s why I keep saying — these **2 hours of training time** are sacred. They are not for theory alone, they are for hands-on.

So today’s **assessment task is simple**:

* Implement the **Register feature** in your Auth controller.
* Create your **Customer class** with personal information.
* Use a repository (simulate it with JSON if needed).
* Connect everything and make sure the flow works end-to-end.

💡 Don’t waste time re-creating projects. You already have my Day 15 **Transflower solution**. Just copy, clone, or unzip it and upgrade for register functionality.

⏳ I am giving you focused time from **9:45 to 10:30**.
That’s 45 minutes of *pure hands-on*.

My expectation:

* By 10:30, I should see your Register implementation working.
* You should push the changes to GitHub so I can track them.

If you face errors, raise them now. I am here to help you debug live.

Remember, this is not about writing perfect code — it’s about developing the habit of shipping code.
Small steps. Consistent pushes. That’s how you grow into a professional developer.”

 Ah, I see what’s happening here 👀

You’re debugging why `http://localhost/products/index` is giving a **“page not found”** error even though the `ProductsController` exists. From the transcript, you already:

* Checked **Program.cs** for routing (`UseRouting()`, `UseAuthorization()`, `MapControllerRoute`, etc.).
* Ensured the **ProductsController** is registered with DI (`ProductRepository` before `ProductService`).
* Added `Console.WriteLine("Index method invoked")` in the controller and in `Index.cshtml` to check execution flow.

Now the key things to double-check:


### ✅ 1. Routing in `Program.cs`

You need this at the bottom of `Program.cs`:

```csharp
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
```

⚡ If `UseRouting()` or `MapControllerRoute()` is missing/mis-ordered, you’ll get a *404 Page Not Found*.

### ✅ 2. ProductsController namespace & suffix

Make sure your controller file looks like:

```csharp
namespace YourApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Index method invoked");
            return View();
        }
    }
}
```

👉 Controller class must end with **Controller**.
👉 Namespace should match project structure.

If you accidentally named it `ProductController` (singular) instead of `ProductsController`, then the route `/products/index` won’t map.

### ✅ 3. View location

ASP.NET Core MVC looks for the view in:

```
/Views/Products/Index.cshtml
```

If your file is not under `Views/Products/Index.cshtml`, you’ll get either a runtime error or fallback to JSON (if returning data instead of a view).


### ✅ 4. LaunchSettings.json / URL

Sometimes Visual Studio launches `https://localhost:xxxx/swagger` or API URL by default. Try typing:

```
https://localhost:xxxx/Products
```

or

```
https://localhost:xxxx/Products/Index
```

(Replace `xxxx` with your port from `launchSettings.json`).


### ✅ 5. Console output check

If `Console.WriteLine("Index method invoked")` is **not printing**, the controller action isn’t being hit → likely a **routing issue**.
If it **does print**, but the page still fails, it’s a **view location issue**.



### 🏗️ Case 1: Everything in One Application (Monolith)

* You put **Product Catalog functions** and **CRM functions** into a **single MVC/Web API project**.
* When a request for "list products" comes → same app handles it.
* When a request for "add customer" comes → same app handles it.
* When hundreds of users are browsing products AND dozens of sales team members are entering customer details at the same time → **all requests hit the same server instance**.
* Over time → request queue grows → app gets **slow, unresponsive, or crashes**.

This is because one **big process** is doing *all jobs*.


### 🏗️ Case 2: Splitting into Modules (Microservices / Separate APIs)

* Create **two independent services**:

  * 📦 **Product Catalog API** → only handles product-related requests.
  * 👥 **CRM API** → only handles customer-related requests.
* Each service can be hosted separately:

  * CRM might be on one VM/container.
  * Product Catalog on another.
* Load balancers can distribute requests between multiple instances of each service.
* Even if CRM service crashes, product catalog still runs fine → **fault isolation**.


### ⚖️ Why Splitting Helps

1. **Scalability** → You can scale Product Catalog (which is usually read-heavy) separately from CRM (which may be write-heavy).
2. **Maintainability** → Smaller codebases are easier to update and deploy.
3. **Performance isolation** → One heavy query in CRM won’t block product browsing.
4. **Independent deployment** → Update CRM without redeploying Product Catalog.


👉 So, what you observed is **the pain of monolithic design**.
👉 The solution is **modularization + service separation** (either via layered architecture in one app OR full microservices).

 Yes 👌 you explained it very well — let me reframe your point in a structured way so it’s crystal clear for your students:


### 🔴 The Problem

* If we **mix everything** (CRM + Product Catalog) into one **project and one class library**,
  → all entities, services, and controllers stay together.
  → Harder to **maintain**, **test**, or **scale**.
  → In production, one bug in CRM might bring down Product Catalog too.

### 🟢 The Right Approach (Microservices Mindset)

* Think of **each module as a self-contained world**:

  * 📦 Product Catalog → its own **API project**, **entities**, **class library**.
  * 👥 CRM → its own **API project**, **entities**, **class library**.
* This ensures:

  * **Separation of Concerns** 🧩 → each team can work independently.
  * **Clean codebase** → no clutter, no mixed responsibilities.
  * **Reusability** → entities and services can be reused across layers.


### ⚪ Practical Note for Learning / Testing

* For **experimentation** and **small student projects**, it’s OK to **keep all classes in one class library** (e.g., `CatalogEntities`).
* This keeps things **simple** while learning basics.
* Later, when scaling, students can **split into multiple class libraries and services** — that’s when real **modularity** kicks in.


👉 So, your point is:
**Start small, keep things together for practice.**
But **develop the mindset** that in real-world architecture, **each module deserves its own class library and service**.

 Yes 👍 I followed your entire flow.
You were helping the students recognize **clean code architecture** alignment and also clarifying the **scope of data transfer techniques in ASP.NET Core**.

Here’s a short recap of what you emphasized (for clarity, so students can take away the right learning points):

## 🟢 Clean Code Architecture & Naming

* **Repositories and Services** must align with **business entities**.

  * If you have a `Customer` entity → you should create `ICustomerRepository` & `CustomerService`.
  * If you have authentication features (login + register), keep them under a single **AuthController** with **methods** (`Login`, `Register`), instead of multiple controllers like `RegisterController`.
* This keeps code **cohesive** and avoids scattering related functions across unrelated files.


## 🟢 Data Transfer in ASP.NET Core

When moving data between controller & views (or between requests), you have **different options depending on the scope**:

### Case 1: Controller → Same View

* ✅ Use **ViewData** (dictionary-style)
* ✅ Use **ViewBag** (dynamic)
* Example: Pre-populating fields in the same view after a failed validation.

### Case 2: Controller → Next Request (Redirect)

* ❌ ViewData / ViewBag will **not work** (they die after the response).
* ✅ Use **TempData** → survives a redirect between consecutive requests.
* ✅ Use **Session** → persists for the whole user session, across multiple requests.
* ✅ Use **Persistence (JSON / Database)** → if you want the data to live beyond session and be reusable.


## 🟢 Example Decisions

* Rajesh’s case (register → redirect to login with prefilled email/password):
  → Use **TempData** (or Session if you need it longer).

* Jagdish’s case (register form not showing):
  → Fix routing with **GET method** properly defined, and add **required fields** for client-side validation.


## 🟢 Homework / Exploration

* Experiment with **TempData vs Session** by moving data across controllers.
* Explore **cookies** and **database-backed persistence** for longer-term state.
* Check your GitHub repo (`tfl.net`) for the **State Management** document — read in advance so you can bring **questions tomorrow**.

 I see what you were doing here 👍
You were closing the session by reinforcing **hands-on discipline**, **GitHub transparency**, and preparing them for **tomorrow’s advanced topics**.

Here are the key points you conveyed (good to keep as a recap for students):


## 🔑 Today’s Key Takeaways

1. **Hands-on Priority**

   * This training is not just conceptual, it’s **practice-oriented**.
   * Use the **2 hours fully** for implementation instead of postponing tasks.

2. **GitHub Repository Discipline**

   * Every participant’s repo must be up-to-date and shared.
   * Seniors are cross-checking progress → missing repos = appears like no work is done.
   * Push your code **during session hours** so everyone can learn from each other.

3. **Code Quality Reminder**

   * Avoid **hardcoding dependencies** (e.g., object creation inside controller).
   * Follow **MVC + Dependency Injection principles**:

     * Define **interfaces** (contracts).
     * Use **services and repositories**.
     * Let the **framework’s DI container** resolve dependencies.


## 🔜 Tomorrow’s Topics

* **Authentication & Authorization**
* **Session Management**
* **Database Connectivity**
* **JWT-based Authentication** (implementing login in `Login.cshtml` + `AuthController`)

👉 Students are expected to:

* **Review others’ repos** (learn alternative implementations).
* **Prepare partial code** in advance so session time is used for integration, not setup.

 