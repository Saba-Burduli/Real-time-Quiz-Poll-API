
# Quiz/Poll Real-Time API

A powerful, scalable Quiz & Poll backend API built with **ASP.NET 9**, leveraging **CQRS**, **SignalR**, **Redis**, **PostgreSQL**, and **Docker**. This project supports anonymous and authenticated voting, real-time updates, analytics, and response exports.

---

##  Features

###  Core Functionalities

* Create quizzes with multiple question types (single/multiple choice, rating, text, image-based)
* Public or private quizzes (via code)
* Real-time results & participation updates using SignalR
* Anonymous & authenticated voting
* IP-based duplicate prevention & rate limiting
* Export results in **CSV** or JSON

###  Analytics

* Real-time voting stats
* Per-question statistics
* Demographics support (future-ready)
* Response heatmaps (future-ready)

###  Tech Stack

* **.NET 9** Web API
* **PostgreSQL** – main database
* **Redis** – for caching, rate-limiting, and SignalR pub/sub
* **SignalR** – real-time updates
* **Docker** + Docker Compose – containerization
* **Serilog** – structured logging
* **MediatR** – CQRS implementation
* **CSV Exporting** – via built-in service

---

##  Patterns Used

### CQRS (via MediatR)

* Command & Query handlers for write/read separation
* Better scaling and testing support

###  GDRS (Generic Data Request Separation)

* Reusable interfaces for `ICommand`, `IQuery`, and `IEventPublisher`
* Promotes loosely coupled design

---

##  Configuration

### PostgreSQL (default)

```
ConnectionString: Host=localhost;Port=5432;Database=quizdb;Username=postgres;Password=password
```

### Redis

```
Redis:ConnectionString=localhost:6379
```

---

##  Running via Docker

```bash
docker-compose up --build
```

App available at: `http://localhost:5000`

Swagger UI: `http://localhost:5000/swagger`

---

##  Logging with Serilog

* Output to console with timestamps, log levels, structured messages
* Extendable to file, Seq, or ElasticSearch

---

## CSV Export

* Export quiz results with headers, answers, timestamps
* Formats: `CSV`, `JSON`

---

##  Author

Made by Saba Burduli
