# 🚗 Car Rental Management System

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23%20WinForms-239120?style=flat-square&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server%20%2F%20LocalDB-CC292B?style=flat-square&logo=microsoftsqlserver)](https://www.microsoft.com/en-us/sql-server/)
[![UI Library](https://img.shields.io/badge/UI-Guna2%20UI-0078D7?style=flat-square)](https://gunai.net/)
[![Academic Project](https://img.shields.io/badge/Origin-2nd%20Year%20College%20Project-orange?style=flat-square)](#about-this-project)

A desktop-based **Car Rental Management System** built with **C# Windows Forms** and **Microsoft SQL Server (LocalDB)**. This system simplifies vehicle fleet administration, customer profile tracking, automated rental issuing, vehicle return condition inspections, and transaction analytics.

---

## 📌 About This Project

> **Academic Context**: This project was originally conceptualized and developed during my **2nd year of university** as part of our Software Engineering / Application Development coursework. It represents an early exploration into full-stack desktop application architecture, multi-tiered database operations, automated wizards, and modern WinForms UI styling.

---

## ✨ Key Features

### 🚘 1. Fleet & Vehicle Inventory Management
- **Full Inventory Tracking**: Track vehicle model, brand, year of manufacture (YOM), fuel type, transmission, seating capacity, and daily hire rates.
- **Condition & Status Enforcement**: Automatic business logic prevents vehicles in damaged or unserviceable conditions (`Damaged`, `Very Bad`, `Needs Repair`) from being issued for rent.
- **Dynamic Search & Filtering**: Instant search by vehicle model, registration number, and availability status.

### 📝 2. Multi-Step Rental Issuance Wizard (`Frm_IssueWizard`)
- **Interactive Step-by-Step Flow**:
  1. Select verified client.
  2. Select available, roadworthy vehicle.
  3. Set rental period (with automatic rental duration & price calculation).
  4. Specify initial mileage & vehicle inspection condition.
  5. Review summary & issue contract.
- **Possession Counter Sync**: Automatically increments client active rental count (`In_Possession`) and transitions vehicle status to `In-Possession`.

### 🔄 3. Return & Damage Inspection Workflow (`Frm_Return`)
- **Return Processing**: Calculate total bill, rental days, and record odometer readings upon return.
- **Damage & Condition Check**: If a returned vehicle is flagged as damaged, the system automatically transitions the vehicle status to `Unavailable` and updates the client's damage record counter.

### 👥 4. Client Profile Management
- Comprehensive customer database with historical orders, total expenditure, currently rented vehicles, and incident records.
- Built-in deletion safeguards preventing removal of clients with active rentals in their possession.

### 📊 5. Analytics Dashboard & Reporting
- Real-time KPIs for total revenue, active rentals, damaged vehicles, and fleet availability.
- Rental history reports with date filtering and data export capability.

### 🔐 6. Role-Based Authentication
- Secure login and registration supporting administrative and active staff roles with contextual page access controls.

---

## 🛠️ Technology Stack

| Component | Technology / Library |
| :--- | :--- |
| **Language** | C# (.NET Framework 4.8) |
| **UI Framework** | Windows Forms (WinForms) |
| **UI Styling** | Guna2 UI Controls & Bunifu UI components |
| **Database** | Microsoft SQL Server LocalDB (`(LocalDB)\MSSQLLocalDB`) |
| **Data Access** | ADO.NET (`System.Data.SqlClient`) with Parameterized Queries |
| **Architecture** | Tiered Architecture (`_Forms`, `_Pages`, `_Models`, `Database.cs`) |

---

## 🚀 Getting Started

### Prerequisites
- **Visual Studio 2019 / 2022** (with *.NET desktop development* workload installed)
- **.NET Framework 4.8 Developer Pack**
- **Microsoft SQL Server LocalDB** (included by default with Visual Studio)

### Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Sho-jii/CarRentalManagementSystem.git
   cd CarRentalManagementSystem
   ```

2. **Open the Solution**:
   - Double-click `CarRentalManagementSystem.sln` to open in Visual Studio.

3. **Database Configuration**:
   - The application is configured to **automatically detect and attach** the local database file (`car_rental.mdf`) at startup.
   - If setting up a fresh SQL Server instance or inspecting schema scripts, execute the comprehensive DDL script:
     ```text
     carRentalQuery.sql
     ```

4. **Build and Run**:
   - Set Build Configuration to `Debug` or `Release` (`Any CPU` / `x64`).
   - Press **F5** or click **Start** in Visual Studio.

### Default Login Credentials
| Username | Password | Role |
| :--- | :--- | :--- |
| `Sho` | `123` | Active / Admin |

---

## 📂 Project Architecture

```plaintext
CarRentalManagementSystem/
├── _Forms/             # Modal dialogs and multi-step transaction wizards
│   ├── Frm_Login.cs          # User authentication & registration
│   ├── Frm_IssueWizard.cs    # 5-step rental issuance wizard
│   ├── Frm_Return.cs         # Return & vehicle inspection flow
│   ├── Frm_Vehicle.cs        # Vehicle creation & editing dialog
│   └── Frm_Client.cs         # Client profile modal
├── _Pages/             # Navigation views hosted on the main dashboard
│   ├── Page_Dashboard.cs     # KPI counters & metrics summary
│   ├── Page_Vehicle.cs       # Fleet grid with status tags & search
│   ├── Page_Rental.cs        # Active rental orders & history
│   ├── Page_Client.cs        # Customer directory & history
│   ├── Page_Report.cs        # Rental & revenue reports
│   └── Page_Users.cs         # User accounts management
├── _Models/            # Business logic & ADO.NET data access layer
│   ├── Database.cs           # Dynamic LocalDB resolution & command executor
│   ├── Vehicle.cs            # Vehicle queries & status rules
│   ├── Rental.cs             # Rental issuance & return logic
│   ├── Client.cs             # Client database operations & safeguards
│   └── Users.cs              # User authentication model
├── MainForm.cs         # Main application shell with sidebar navigation
├── Program.cs          # Application bootstrapper & database initialization
├── carRentalQuery.sql  # Complete database schema, tables, and sample seed data
└── README.md           # Project documentation
```

---

## 📄 License
This project is licensed under the [MIT License](LICENSE).
