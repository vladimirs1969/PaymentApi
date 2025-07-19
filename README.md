# 💳 Payment API – ASP.NET Core Demo Project

A secure and extensible Web API for managing payments, built with **ASP.NET Core**, **EF Core**, **Redis**, and **JWT Authentication**.  
Designed as a training and portfolio project to showcase production-grade practices.

---

## ✅ Features

- 🔐 **JWT Authentication** with protected endpoints
- 📦 **EF Core** + SQLite database with migrations
- ⚡ **Redis** caching for GET requests
- 🧩 **Swagger UI** for testing and documentation
- ❗ **Global error handling** via custom middleware
- 🧪 Ready for unit and integration testing

---

## 🛠️ Stack

| Technology         | Purpose                          |
|--------------------|----------------------------------|
| ASP.NET Core       | REST API framework               |
| Entity Framework   | ORM for SQLite database          |
| Redis              | Distributed caching              |
| JWT                | Authentication and Authorization |
| Swagger / Swashbuckle | API documentation             |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download)
- [Redis](https://redis.io/) running on `localhost:6379`

### Clone & Run

```bash
git clone https://github.com/yourname/payment-api.git
cd payment-api
dotnet restore
dotnet ef migrations add Init
dotnet ef database update
dotnet run
```

---

## 🔐 Authentication

To access protected endpoints:

1. POST `/api/auth/login`  
   ```json
   {
     "username": "admin",
     "password": "1234"
   }
   ```
2. Copy the token and use the `Authorize` button in Swagger UI

---

## 📬 Available Endpoints

| Method | Endpoint            | Description               |
|--------|---------------------|---------------------------|
| POST   | `/api/auth/login`   | Get JWT token             |
| GET    | `/api/payments`     | Get all payments (cached) |
| GET    | `/api/payments/{id}`| Get payment by ID         |
| POST   | `/api/payments`     | Create payment            |
| PUT    | `/api/payments/{id}`| Update payment            |
| DELETE | `/api/payments/{id}`| Delete payment            |

---

## 🧱 Suggested Extensions

- Refresh tokens and logout mechanism
- Role-based authorization and policy handlers
- File attachments to payments
- Payment status (Pending / Completed / Failed)
- Audit trail and history
- Unit & integration tests
- Docker + GitHub Actions CI/CD

---

## 📂 Project Structure

```
PaymentApi/
├── Controllers/
├── Models/
├── Services/
├── Middleware/
├── Program.cs
├── appsettings.json
```

---

## 📘 License

MIT © 2025 Your Name
