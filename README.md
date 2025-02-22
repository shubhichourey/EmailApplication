# 📧 Email Application - ASP.NET Core MVC

## 🚀 Overview
This is an **ASP.NET Core MVC application** built using **Onion Architecture** that allows users to **compose and send emails** to all registered users in the database using **Google SMTP (Gmail SMTP Server)**.

## 🏗️ Architecture
The project follows the **Onion Architecture**, which consists of:
- **Controllers (Presentation Layer)** → Handles user requests.
- **Application Layer** → Contains business logic and service interfaces.
- **Domain Layer** → Defines core entities and business rules.
- **Infrastructure Layer** → Handles data persistence, repositories, and email sending via SMTP.

## 🛠️ Technologies Used
- **ASP.NET Core MVC**
- **Entity Framework Core (EF Core)**
- **SQL Server**
- **Google SMTP (Gmail)**
- **Dependency Injection**
- **Repository Pattern**
- **Bootstrap (Frontend UI)**

## 📂 Project Structure
📦 EmailApplication 
┣ 📂 EmailApplication.Web (Presentation Layer - MVC) 
┣ 📂 EmailApplication.Application (Business Logic & Service Layer) 
┣ 📂 EmailApplication.Domain (Entities & Interfaces) 
┣ 📂 EmailApplication.Infrastructure (Data Persistence & SMTP Service)  
 📜 EmailApplication.sln (Solution File)

## ✨ Features
✅ **Compose & Send Emails** using Google SMTP  
✅ **Retrieve Registered Emails** from Database  
✅ **Onion Architecture for Clean Code**  
✅ **Entity Framework Core for Database Management**  
✅ **Bootstrap UI for User-Friendly Interface**  





