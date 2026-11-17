 
# C# Dependency Injection Demo: Shop Order System

A beginner-friendly C# console application demonstrating **Constructor Dependency Injection** and **Loose Coupling** using interfaces.

## Overview

Instead of hardcoding dependencies inside the main class using the `new` keyword, this project uses **interfaces** and **constructor injection** to decouple the order workflow from specific notification and payment providers.

* **`IMessageService` & `IPaymentServ`:** Define the contracts that any notification or payment provider must implement.
* **`EmailService` & `CashPaymentSe`:** Concrete implementations of those contracts.
* **`program`:** The consumer class that receives both dependencies via its constructor without knowing which concrete classes are running underneath.

## Prerequisites & How to Run

**Prerequisites:**
* [.NET SDK](https://microsoft.com) (6.0 or later recommended)

**Steps:**
1. Clone the repository or save the source code as `Program.cs` inside a C# console project folder.
2. Open your terminal or command prompt in the project directory.
3. Run the application:
   ```bash
   dotnet run
   ```

## Expected Output

```text
testind gependency injection
order has been placed successfully
order confirmation Email sent
cash payment received 
```

## How to Extend

To add a new payment method (e.g., M-Pesa) or notification channel (e.g., SMS):
1. Create a new class that implements `IPaymentServ` or `IMessageService`.
2. Instantiate your new class in `Main` and pass it into the `program` constructor.
3. No changes are needed inside the `program` class itself.
