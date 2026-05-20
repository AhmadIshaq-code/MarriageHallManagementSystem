# Marriage Hall Management System

## 📌 Project Overview

The Marriage Hall Management System is a desktop application developed using C# Windows Forms and MySQL Database.
The system is designed to manage marriage hall operations digitally, including staff management, customer management, bookings, payments, and invoice generation.

---

# 🚀 Technologies Used

* C# Windows Forms
* MySQL Database
* ADO.NET
* MySQL Workbench
* BCrypt.Net (Password Hashing)
* 3-Layer Architecture

---

# 🏗️ Project Architecture

The project follows **3-Layer Architecture**:

## 1. Forms Layer

Handles the user interface and user interaction.

Examples:

* LoginForm
* MainForm
* CustomerForm
* BookingForm
* ViewBookingForm
* StaffForm

---

## 2. Models Layer

Contains classes representing entities and data objects.

Examples:

* Staff.cs
* Customer.cs
* Booking.cs
* User.cs

---

## 3. Database Layer

Handles all database operations.

Examples:

* DBConnection.cs
* StaffDB.cs
* CustomerDB.cs
* BookingDB.cs
* LoginDB.cs

---

# ✨ Features

## 🔐 Authentication System

* Staff Login
* Secure password hashing using BCrypt

## 👨‍💼 Staff Management

* Add Staff
* Edit Staff
* Delete Staff
* View Staff Records

## 👥 Customer Management

* Add Customer
* Edit Customer
* Delete Customer
* View Customer Records

## 📅 Booking Management

* Create Hall Bookings
* Select Customers
* Select Food & Drinks
* Automatic Cost Calculation
* Grand Total & Balance Calculation

## 🧾 Invoice System

* Generate Booking Invoice
* Print Invoice

---

# 🗄️ Database Setup

## Step 1 — Create Database

```sql
CREATE DATABASE marriage_hall;
```

---

## Step 2 — Use Database

```sql
USE marriage_hall;
```

---

## Step 3 — Create Staff Table

```sql
CREATE TABLE staff
(
    StaffId INT PRIMARY KEY AUTO_INCREMENT,
    StaffName VARCHAR(50),
    StaffPhone VARCHAR(20),
    StaffGender VARCHAR(20),
    StaffPassword VARCHAR(255)
);
```

---

## Step 4 — Create Customers Table

```sql
CREATE TABLE customers
(
    CustId INT PRIMARY KEY AUTO_INCREMENT,
    CustName VARCHAR(50),
    CustAdd VARCHAR(100),
    CustPhone VARCHAR(20)
);
```

---

## Step 5 — Create Booking Table

```sql
CREATE TABLE bookingtable
(
    BId INT PRIMARY KEY AUTO_INCREMENT,

    BDate DATE,

    BTime VARCHAR(20),

    CustId INT,

    CustName VARCHAR(50),

    Persons INT,

    Dishes VARCHAR(200),

    Drinks VARCHAR(200),

    CostDrink INT,

    CostFood INT,

    OtherCharges INT,

    GrdTotal INT,

    Advance INT,

    Balance INT,

    FOREIGN KEY (CustId)
    REFERENCES customers(CustId)
);
```

---

# ⚙️ Configuration

Open:

```text
DBConnection.cs
```

Update connection string:

```csharp
string connectionString =
"server=localhost;database=marriage_hall;uid=root;pwd=yourpassword;";
```

Replace:

* `root` with your MySQL username
* `yourpassword` with your MySQL password

---

# ▶️ How to Run the Project

1. Install Visual Studio 2022
2. Install MySQL Server
3. Install MySQL Workbench
4. Open the project in Visual Studio
5. Create the database and tables
6. Update connection string
7. Run the project using:

   * `Ctrl + F5`
   * or Click **Start**

---

# 📦 Required NuGet Packages

Install these packages:

```text
MySql.Data
BCrypt.Net-Next
```

---

# 🔒 Security Features

* BCrypt Password Hashing
* Parameterized SQL Queries
* Foreign Key Relationships

---

# 📚 Learning Concepts Used

* Object-Oriented Programming (OOP)
* 3-Layer Architecture
* CRUD Operations
* Event-Driven Programming
* Database Connectivity
* Data Binding
* Authentication System

---

# 👨‍💻 Developed By

Muhammad Ahmad Ishaq

BS Computer Science

---

# 📄 License

This project is developed for educational purposes.
