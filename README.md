# SweetHaven Cakes and Pastries

A Windows desktop point-of-sale and inventory system for a bakery — tracking products, customers, suppliers, sales, and purchases against a shared MySQL database, all from a single dashboard.

Final project for **CCS 5 (Fundamentals of Information Management)**, Silliman University College of Computer Studies — a learning project, built mainly to practice how to interact with a database. Everything here hangs off one: all records, every CRUD operation, and the dashboard's numbers come straight from SQL queries against a live MySQL server.

## Screenshots

![Dashboard](docs/screenshots/dashboard.png)
![Products](docs/screenshots/products.png)
![Customers](docs/screenshots/customers.png)
![Suppliers](docs/screenshots/suppliers.png)
![Sales Transactions](docs/screenshots/sales_transactions.png)
![Purchase Transactions](docs/screenshots/purchase_transactions.png)

---

## Why a bakery?

A class project isn't a product — it's an exercise. The aim of CCS 5 was to learn how to build an application *around* a database, so we picked a domain where the data model is easy to see: a bakery's day-to-day recordkeeping. It's simple enough to reason about — products, customers, suppliers, sales, and purchases — yet rich enough to practice real database work: related tables, full CRUD on every entity, and aggregate queries that span them.

## Solution

The result is a Windows desktop app where every screen reads and writes through the same MySQL database:

- **Dashboard** — live counts for every module plus computed totals: revenue from sales (`quantity × selling price`) and spend from purchases (`quantity × cost`), all summed in SQL
- **Products** — inventory with cost, selling price, and stock, linked to their suppliers
- **Customers** — a searchable record of everyone who orders
- **Suppliers** — who supplies what ingredient or product
- **Sales & Purchases** — record transactions against products; quantities flow into stock and the dashboard's numbers

Every module is a full add / update / delete / clear loop against MySQL, so all screens share one source of truth.

## What's unique: a database in the driver's seat

This wasn't a UI project with a database bolted on — it's the reverse. The database is the center of the design:

- **ADO.NET the classic way.** Forms load through `MySqlDataAdapter` + `DataSet`, and every button press is a `SELECT`, `INSERT`, `UPDATE`, or `DELETE` sent to the server.
- **Relationships are the point.** Sales and purchases reference `product` (and products reference `supplier`); the dashboard's revenue/expense figures are `SUM` **joins across tables**, not precomputed numbers.
- **Consistent data everywhere.** Edit a product's price once and every sales record and dashboard total reflects it immediately — the payoff of letting one database own the truth.

## Built with

| What | Used for |
|---|---|
| VB.NET (Windows Forms, .NET Framework 4.7.2) | desktop UI and app logic |
| MySQL | the single shared `sweet_haven` database |
| MySql.Data / ADO.NET | DataAdapter, DataSet, and all CRUD queries |
| Visual Studio `.slnx` | solution and project management |
