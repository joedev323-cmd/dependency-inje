# Python Dependency Injection Demo: Shop Order System

A beginner-friendly Python script demonstrating **Constructor Dependency Injection** and **Duck Typing** in a simulated shop order workflow.

## Overview

Rather than instantiating services directly inside the `Program` class, required dependencies are passed into `__init__` from the outside. Because Python uses **duck typing**, no strict interfaces are required—any injected object with the matching method names (`send_message()` and `make_payment()`) will work seamlessly.

* **`EmailService` & `CashPaymentSe`:** Standalone service classes handling notifications and payments.
* **`Program`:** Receives service instances via `__init__` and executes `place_order()` and `make_pay()`.

## Prerequisites & How to Run

**Prerequisites:**
* [Python 3.x](https://python.org) installed

**Steps:**
1. Save the Python script as `main.py`.
2. Open your terminal or command prompt in the directory containing `main.py`.
3. Run the script:
   ```bash
   python main.py
   ```

## Expected Output

```text
testing dependency injection
order has been placed successfully
order confirmation Email sent
cash payment received
```

## How to Extend

To add a new payment method (e.g., M-Pesa) or notification channel (e.g., WhatsApp):
1. Define a new class with a `make_payment(self)` or `send_message(self)` method.
2. Instantiate the new class at the bottom of `main.py` and pass it into `Program(nserv, nserv2)`.
3. The `Program` class requires zero modifications.
