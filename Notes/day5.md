### 🌱 Week 2 – Deepening Our .NET Journey with C# and ASP.NET Core

"Friends, last week we planted the seeds. We built our very first .NET applications — console apps, small class libraries, and even a simple ASP.NET MVC project. We did not aim to master everything in detail, but we *got our hands dirty*. And that is how learning begins.

Now this week, we move from seeds to sprouts. Our focus is:

1. **Understanding C# as the backbone language of .NET.**
   Remember: .NET is the ecosystem, C# is the tool we use to *express* our solutions.

2. **Exploring language constructs and object-oriented programming in C#.**
   Let us not memorize keywords mechanically. Instead, let’s see *why* each construct exists, and how it helps us build real applications.

   * Variables, data types → Represent the state of our application.
   * `if`, `switch`, loops → Help us control the flow of decisions.
   * Classes, objects, and methods → Help us encapsulate logic.
   * Inheritance and interfaces → Help us design *extensible* systems.
   * Generics, collections, LINQ → Make handling data more powerful.
   * Async/await → Let us deal with modern, scalable web applications.

   By the end of this week, each of you should feel confident saying:
   *“I can design an object-oriented solution in C# for a real-world business problem.”*

3. **Exploring ASP.NET Core Web Development.**
   On Friday, we created a simple MVC project. This week, we’ll dig deeper into:

   * **Model–View–Controller (MVC)** pattern: Why do we separate concerns?
   * How do we define *Models* (entities), *Repositories* (data access), and *Services* (business logic)?
   * How do Controllers glue everything together?
   * How do we return HTML views vs. JSON APIs?

   Slowly, you’ll notice: learning MVC is not about memorizing “controllers” and “actions.” It’s about *thinking like an architect* — keeping code clean, modular, and testable.

### 🛠 Build vs. Tooling

Last week, we used **.NET CLI** and **VS Code** — and not the heavy Visual Studio IDE. Why?
Because this forces us to understand the *real build process*:

* `dotnet new` → scaffolds projects.
* `dotnet build` → compiles your code into DLLs.
* `dotnet run` → actually executes it.
* `dotnet add reference` / `add package` → teaches us dependency management.

Once you master this, using Visual Studio will feel like flying in an aircraft with autopilot: powerful, but you already know how to fly manually.


### 🧩 The Mentor’s Perspective

Now, here’s a key mindset:

* A **trainer** gives you theory.
* A **teacher** tests you.
* A **mentor** walks beside you, nudges you when you’re stuck, and helps you connect learning to real-world problems.

So in this week, don’t think “I need to cover 20 C# keywords.” Instead think:
👉 “How can I use C# language features to build a small, clean, testable banking or shopping application?”

That’s what we will actually do.



### 📌 Plan for This Week

* **Day 1-2**: Refresh C# fundamentals → write a mini OOP-based console application.
* **Day 3-4**: Expand into ASP.NET MVC → entities, repositories, services.
* **Day 5**: Introduce design principles (SOLID, DRY, KISS) + see how they apply in our small project.
* **Weekend assignment**: Extend the project (add new features to the app) and push to GitHub.

By the end of the week, you will not only know “C# keywords” but also feel the confidence of **using C# as a tool to design an enterprise-style solution**.



### Mentor Storytelling Mode 🌱

Imagine we are in a classroom—not the academic one where we prepare for marks—but a **workshop where we prepare for projects**. Everyone here is either a **C# developer, Java developer, or JavaScript developer**. Different backgrounds, but the moment we come together on a project, what matters is **how we write code that lives beyond us**.

Because in the industry, the truth is:

* The code you write today may be read by a junior tomorrow.
* The project you own today might be handed over to another team next quarter.
* And during that **KT (Knowledge Transfer)**, the less explanation required, the more mature your codebase is.

That’s where **principles and patterns** come in.


### Why Principles and Patterns?

When we build **.NET applications** (whether console apps, APIs, or MVC web apps), we’re not just solving the problem in front of us. We’re solving it in a way that makes:

1. The **intent clear** – so juniors or newcomers understand.
2. The **code maintainable** – so the next team can extend it.
3. The **transfer seamless** – so KT takes hours, not weeks.

That’s why we lean on:

* **Creational design patterns** – Singleton, Factory, Builder (how objects are created).
* **Structural design patterns** – Adapter, Facade, Composite (how objects relate).
* **Behavioral design patterns** – Observer, Strategy, Command (how objects collaborate).

Instead of learning them in isolation, we’ll **spot them inside our ASP.NET Core projects**. Because nothing sticks better than *“oh, this is Factory in action in my codebase”*.



### From Principles to Practice in ASP.NET

Take the example of **request/response in ASP.NET Core**.

* A client sends a request.
* That request hits the server, flows through **middleware** (think of middleware as decorators wrapping the request pipeline – structural pattern in disguise).
* ASP.NET Core then decides: “is this going to a controller, an API, or a Razor page?”
* Your controller processes data – maybe with the help of a **Repository** (which itself may use Factory to construct DB connections).
* Then the response goes back – maybe in **HTML (View)** or in **JSON** for APIs.

Every step is layered with **patterns and SOLID principles**.

For example:

* **S** in SOLID → Single Responsibility: Controller shouldn’t also fetch DB connections, it should delegate to a service/repository.
* **O** → Open/Closed: Services can be extended (new features) without modifying existing ones.
* **D** → Dependency Inversion: We inject interfaces (e.g., `IProductRepository`) into controllers instead of hard-coding implementations.



### Why We Started with VS Code

Now, I know some of you are thinking: “Ravi, why not directly use Visual Studio Professional or Enterprise? Why struggle with VS Code + CLI commands?”

Here’s the mentor’s perspective:

* **Visual Studio (IDE)** is like a luxury car – powerful, lots of buttons, automates scaffolding.
* **VS Code (Editor + Extensions)** is like a bike – lightweight, you feel the mechanics, you learn to balance.

When you’re **learning from scratch**, VS Code makes you see the anatomy of a .NET application:

* Solution → Projects → Classes → Namespaces.
* Commands like `dotnet new`, `dotnet build`, `dotnet run`.
* Dependencies managed via **NuGet**.

So when you finally move to Visual Studio Enterprise in a project, you appreciate how much work it’s saving you, because you know what’s happening underneath.



### Next Step – Our Week 2 Agenda

Last week was about:

* Understanding solutions/projects.
* Console apps, class libraries.
* ASP.NET MVC basics.

This week, our focus is:

1. **Building web applications with ASP.NET Core**.
2. Exploring the **Model–View–Controller (MVC)** pattern.
3. Writing entities, repositories, services → tying them together in a simple **E-Commerce style project**.
4. Observing **design principles and patterns in practice** as we code.

By the end of this, if you walk into an existing ASP.NET Core project at work, you won’t just say *“this is a folder named Services”*. You’ll say *“ah, this is an implementation of the Repository + Dependency Injection pattern”*.

That’s when you move from **coder** → **craftsman**.



### 🌍 The Story of Versions – Console App with .NET 8, Library with .NET 9

Let’s imagine we are in a workshop with our tools laid out. On one table, we’ve built a **console app targeting .NET 8.0**. On another table, we’ve built a **class library targeting .NET 9.0**.

Now George asks the wise question:

👉 *“If both runtimes (8 and 9) are installed on the machine, will they still work together?”*

And here’s the mentor’s gentle answer:

* Yes, both runtimes can **co-exist** on the same machine.
* Your console app will happily run with .NET 8 runtime, your library can be built with .NET 9 runtime.
* But… if you try to **reference the .NET 9 library inside the .NET 8 console app**, it won’t work.
  Why? Because your EXE cannot call into a DLL that’s compiled with a higher version of the runtime.

It’s like inviting a guest who speaks Version 9 of the language into a household that only understands Version 8. The runtime will politely say:
❌ *“Sorry, this conversation can’t happen unless both speak the same language.”*

So the **rule of thumb** is:

* The **EXE (consumer)** and the **DLL (provider)** must target the same framework version if they are directly referenced.
* Or, the DLL can target a **lower version** than the EXE, but not a higher one. (Backward compatibility works, forward compatibility doesn’t).



### 🔍 Why This Matters for Us as Developers

Think of your **console app** as the *driver* and your **class library** as the *engine*.

* If your driver only knows how to drive cars from 2023 (v8), but your engine is from 2024 (v9), the parts won’t fit.
* But if your engine is from 2022 (v7), the driver from 2023 (v8) can still use it — because newer drivers can usually operate older engines.

That’s why in **solution design**, we usually:

1. Align all projects to the same target framework (simplest & safest).
2. Or, ensure the libraries target the **lowest common denominator** framework version, so they can be reused across multiple applications.


### 💡 Mentor’s Wisdom

This small versioning detail is actually a **big architectural lesson**:

* Always check **target frameworks** in your `.csproj` files.
* When building **class libraries meant for reuse**, target the **earliest stable version** possible — so your library is usable by more consumers.
* When building **apps**, align them with the latest runtime that your production environment supports.

This way, you avoid the “DLL hell” of mismatched versions.


So George’s doubt? ✔️ Crystal clear.

* Having both runtimes on the machine? Totally fine.
* Mixing references between them? 🚫 Not unless you match versions.



### 🌱 The Path: From VS Code to Visual Studio

Team, you’ve done the **hard work** already. You’ve sat with VS Code, written code from scratch, created projects using the CLI, and *really seen the anatomy* of how .NET works.

Now, once you’re **comfortable with coding in C# + VS Code**, then, and only then, step into **Visual Studio**.

Why? Because Visual Studio is like a **five-star hotel**. Everything is served in style — templates, solution explorers, debuggers, diagrams. But if you only start there, you’ll never know what’s happening under the hood.

Think of it this way:

* **VS Code** = cooking at home. You chop vegetables, you light the stove, you see how flavors come together.
* **Visual Studio** = going to a restaurant. You order, food comes beautifully plated. Amazing, but you don’t know the struggle behind the dish.

That’s why our journey started with VS Code. Now, we peek into Visual Studio only to understand how it can make us faster once we know the basics.

 

### 🚫 A Word on GitHub Copilot & AI-Generated Code

Yes, AI is everywhere. Yes, Copilot can generate entire controllers, services, even LINQ queries. But here’s the catch:

👉 If you let Copilot write your code **before you understand it**, you’ll never be able to debug it when it breaks.

And believe me, it *will* break.

This is what we call **“vibe coding.”**

* Developers paste AI-generated snippets.
* Applications get built quickly.
* But when something fails in production, no one knows why.

The maintenance cost skyrockets because the developers never built **mental visualization** of their code.

So here’s the mentor’s wisdom:

* First, learn to write code on your own.
* Build your confidence, understand the flow.
* Then, when you use AI, you’ll ride it like a horse. *You’re the rider, not the runner chasing the horse.*

 

### 🏗 Visual Studio Explorer Views

Now, Visual Studio gives us amazing tools to *visualize our codebase*:

* **Solution Explorer** → project structure.
* **Class View** → object-oriented view (namespaces → classes → properties → methods).

For example:

* You open `Product` class. By default, it doesn’t extend anything. But behind the scenes, it’s always inheriting from the **mother of all classes**: `System.Object`.
* When you click “Base Class” in Visual Studio, you’ll see:

  * `ToString()`
  * `Equals()`
  * `GetHashCode()`
  * `GetType()`
  * Even `MemberwiseClone()` (link to deep copy/shallow copy concepts).

You don’t need to master all this right now. Just know: **every class in .NET has Object as its ultimate parent**.

Now compare with `HomeController` in MVC:

* It doesn’t just inherit from `Object`.
* It extends `Controller`, which itself extends `ControllerBase`.
* And `ControllerBase` implements interfaces that handle **request/response pipelines**.

So, business entity classes like `Product` are **POCOs** (Plain Old CLR Objects).
But controllers inherit from framework classes to gain **web-handling behavior**.

  

### 🔧 Practical Mentor Advice

* Use Visual Studio to **visualize**, but continue coding in VS Code for now.
* Let Visual Studio show you the bigger picture (class hierarchies, base classes, debug windows).
* But keep **CLI + VS Code** as your daily driver until you’re confident.

Why? Because Visual Studio is heavy, takes GBs of space, eats up RAM. VS Code is light and closer to the machine.

 

### ☕ The Tea Story

Debugging in VS Code vs. Visual Studio is like having tea.

* Whether you drink it at a roadside stall or in a 5-star hotel, the **taste of the tea doesn’t change**.
* The difference is only in the experience.

In projects, the same:

* If you’re on a budget, VS Code + CLI does the job.
* If you have enterprise support, Visual Studio gives you a luxury ride.

But never forget: it’s **the tea (your code)** that matters, not the cup.

 

### ⚙️ PDB & JSON Files

Finally, Pallavi asked a brilliant question about `.dll`, `.pdb`, and `.json` files.

* **DLL** → compiled code (your business logic).
* **PDB** → Program Debug Database, used to map your breakpoints to actual source code during debugging.
* **JSON (appsettings.json)** → configuration file. Keeps things like DB connection strings **outside** your DLLs so you can change them without recompiling.

This is why in .NET, code and configuration are **separated** — making apps flexible and maintainable.

 

✅ So to wrap this up:

* Learn basics slowly (VS Code + CLI).
* Use Visual Studio for visualization once you’re ready.
* Avoid vibe coding → *write before you generate*.
* Understand POCOs vs Controllers.
* And always separate code from configuration.

 
 

### 🌱 The Question: Can Settings Live at the Solution Level?

Arif asked a very sharp question:
👉 *“We see `appsettings.json` inside projects. But since many projects in the same solution may use the same connection string, why not keep it once at the solution level?”*

This is a natural thought. After all, in the real world, if multiple tenants in a building use the same water tank, why not place the tank on the terrace (solution level) instead of in every flat (project level)?

But here’s the truth of **.NET architecture**:

* **Executor matters.** Only executables (`.exe` – Console app, ASP.NET app) launch a process.
* Libraries (`.dll`) don’t execute on their own – they are passengers inside the process.
* So, configuration belongs to the **process owner** (the application project), not the passengers (libraries).

That’s why we keep `appsettings.json` inside the **web app or console app project**.
When the EXE starts, it reads the configuration, then all referenced DLLs can piggyback on that same configuration.

 

### 🏠 The House Analogy

Think of it like this:

* **The application (EXE)** is the house.
* **DLLs (libraries)** are the family members living in the house.
* The **appsettings.json** is the house’s electricity meter.

Would you put the electricity meter on the colony gate (solution)? No. Each house needs its own meter. But once inside, every member of the family enjoys that electricity.

Same way:

* The connection string is in the EXE’s `appsettings.json`.
* Every DLL inside that process can read it via **dependency injection / configuration APIs**.

This way, no duplication is needed in every library.

---

### ⚙️ References Between Class Libraries

Arif then asked another clever one:
👉 *“Can one class library reference another class library?”*

The answer is **Yes. Absolutely.**

And that’s how we build **layered architecture**:

* **Entities Project** → plain classes like `Product`, `Order`.
* **Repository Project** → references Entities, handles database.
* **Services Project** → references Repository, contains business logic.
* **UI / MVC Project** → references Services, exposes controllers & views.

So, yes, nesting of DLL references is possible. That’s what gives us **clean separation of concerns**.

⚠️ Only one golden rule:

* Always avoid **cyclic references** (where A references B, and B references A). That creates chaos.

 

### 🛠 Bringing It Together – Our E-Commerce Skeleton

Ravi walked us through the **skeleton creation**:

1. Create a solution.
2. Add a class library (`CatalogLib`).
3. Add an MVC project (`OnlineShoppingPortal`).
4. Add references properly (`MVC → CatalogLib`).
5. Build and run.

And voila — you have a **layered solution** where the web app executes, reads configuration from its own `appsettings.json`, and passes that context down to all referenced DLLs.

 

### ✨ Mentor’s Closing Wisdom

* **Configuration is always owned by executables.**
* **DLLs borrow config at runtime.**
* **Libraries can reference each other**, forming layers, but never form circles.
* And remember: when the EXE runs, **all DLLs are loaded into the same process**, so they behave like one big family.

 
 

So, as front-end developers, you often see your world from the browser window. Your Angular, React, or Vue app is loaded on your personal device, and from there you keep sending requests to some server somewhere in the cloud. That’s your **client-side** story.

But let’s flip the perspective for a moment. Imagine that server—it’s not just a box in the corner. On that server, sitting on top of an OS (often Linux in production, even though you may practice on Windows), there’s a **process running**. If it’s a .NET Core application, that process is a `.exe` hosted by the **.NET runtime**. Inside the runtime, the **CLR** (Common Language Runtime) is working like an engine room, loading assemblies, checking code, compiling JIT, and sweeping garbage behind you.

Now here’s the magic: because it’s a **web app**, it can’t just sit quietly like a console app. It must **listen**. Listen on a **port number** for incoming HTTP requests. And who makes sure that listening happens? A tiny but mighty HTTP server called **Kestrel**. Think of Kestrel as the gatekeeper—it opens the door when a request packet arrives and hands it off to a worker thread from the thread pool.

That’s where **ASP.NET Core’s middleware pipeline** takes over. Middleware is like a series of security checkpoints in an airport. Every request passes through them—logging, authentication, routing, and so on—before finally reaching the **Controller**.

Now, in MVC days, the Controller would process data, create a **Model**, and hand it to a **View** to render HTML. Perfect for traditional web apps. But today, the world of front-end has shifted. Most of you are Angular/React developers—you don’t need server-side views anymore. You just need clean JSON data.

That’s why instead of MVC, we lean towards **Web API projects**. In ASP.NET Core, you can spin up a Web API using the command:

```bash
dotnet new webapi -o EStoreWebAPI
```

This creates a project skeleton that doesn’t waste time with Razor views. Instead, it’s optimized for REST endpoints.

Now here’s where .NET Core shines: you don’t even need heavy controllers if you don’t want them. Using **Minimal APIs**, you can declare endpoints in just a few lines:

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => "Hello World");

app.MapGet("/api/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Gerbera", Price = 100 },
        new { Id = 2, Name = "Rose", Price = 200 },
        new { Id = 3, Name = "Tulip", Price = 300 }
    };
});

app.Run();
```

That’s it. Two endpoints. `/hello` returns a string, `/api/products` returns a JSON array.
If you run it (`dotnet run`), the app starts on `http://localhost:XXXX` (with a random port).

From there, you can test it in **Postman** or directly from your Angular app using `HttpClient.get(...)`.

But wait—if you try to hit it from Angular, your browser might block the request due to **CORS policy**. That’s where you as a Web API developer need to add:

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

app.UseCors("AllowAll");
```

Now Angular, React, or any SPA can consume it without error.

 

🌟 **The bigger picture**:

* Your **client app** = Angular (browser, single-page app).
* Your **server app** = ASP.NET Core Web API (minimal or MVC).
* Communication = **HTTP requests/responses**, usually JSON.
* Glue in between = **CORS policies**, **Kestrel server**, and **Middleware**.

This is the foundation of modern web development. Once you see this pipeline, you’ll never again confuse where the “View” belongs—it’s in Angular now, not in .NET.

 