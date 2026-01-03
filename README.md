📚 Library Management System (Console Application)
📌 Overview

This is a console-based Library Management System built using C# and .NET, designed to manage books, members, and borrowing operations in a structured and maintainable way.
The project focuses on clean architecture, SOLID principles, and real-world business logic, commonly discussed in backend interviews.

🎯 Features

Add, update, and remove books

Register library members

Issue and return books

Track available and borrowed books

Validate borrowing rules (availability, limits)

Display reports for books and members

🧠 Design & Architecture

The application follows clean separation of concerns:

Models – Book, Member, BorrowRecord

Interfaces – IBookService, IMemberService, IBorrowService

Services – Business logic for managing library operations

Program (Entry Point) – Handles user input and menu navigation

This structure makes the application:

Easy to extend

Easy to test

Easy to maintain

🧱 SOLID Principles Used

SRP – Each service handles a single responsibility

OCP – New features can be added without modifying existing logic

LSP – Interfaces ensure substitutability

ISP – Small, focused interfaces

DIP – Services depend on abstractions, not implementations

🛠️ Tech Stack

Language: C#

Framework: .NET

Concepts: OOP, SOLID, Interfaces, LINQ

Application Type: Console Application

▶️ How to Run

Clone the repository

Open the solution in Visual Studio

Build the project

Run the application

Follow the console menu options

📈
