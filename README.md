# 📚 Library Book Management System

## 📌 Project Overview
The **Library Book Management System** is a simple web application designed to manage library books and issue records.  
It allows administrators to add, update, delete books and manage book issuing and returning.

This project is built using **ASP.NET Core Web API** for the backend and **Blazor** for the frontend.

---

## 🎯 Problem Statement
Create a system to manage library books and issue records.

---

## 🛠️ Technologies Used
- **Backend:** ASP.NET Core Web API
- **Frontend:** Blazor WebAssembly
- **Database:** SQL Server
- **ORM:** Entity Framework Core
- **API Testing:** Swagger

---

## 🗂️ Features

### Backend
- CRUD operations for books
- Issue book
- Return book
- Track issue history

### Frontend
- View book list
- Issue book form
- View issue history

---

## 🗄️ Database Structure

### 📘 Books Table
| Column | Description |
|------|------------|
| BookId | Primary Key |
| Title | Book title |
| Author | Author name |
| AvailableCopies | Number of copies available |

### 📕 Issues Table
| Column | Description |
|------|------------|
| IssueId | Primary Key |
| BookId | Foreign Key |
| StudentName | Name of student |
| Status | Issued / Returned |

---

## 📁 Project Structure

### Backend (ASP.NET Core Web API)
