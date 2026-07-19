# PatientFlow

PatientFlow is a C# WinForms desktop application designed to simplify patient record management in a clinical environment. The application enables healthcare staff to create, view, update, search and delete patient records while maintaining persistent data storage through JSON serialisation. The project was developed to strengthen desktop application development skills using .NET and WinForms.

---

## Features

- **Patient Management** – create, edit, view and delete patient records (CRUD functionality)
- **Patient Search** – search patients by name with real-time filtering
- **Priority & Status Tracking** – manage patient priority levels and treatment status
- **Data Persistence** – patient records are automatically saved and loaded using JSON
- **Input Validation** – validates user input to improve data integrity and prevent invalid entries
- **Patient Statistics** – displays live statistics for total patients, waiting patients, patients in treatment and discharged patients
- **Modern Desktop Interface** – clean WinForms interface designed for usability and efficient workflow

---

## Tech Stack

### Framework / Language

- C#
- .NET
- Windows Forms (WinForms)

### Data Storage

- JSON Serialization
- Local File Storage

### Programming Concepts

- Object-Oriented Programming (OOP)
- LINQ
- Event-Driven Programming
- Separation of Responsibilities (Service Layer)

### Development Tools

- Visual Studio
- Git & GitHub

---

## Project Architecture

The project follows a simple layered structure to separate responsibilities.

- **Models** – stores the Patient class and application data models.
- **Services** – responsible for loading and saving patient data.
- **UI (WinForms)** – handles user interaction, validation and presentation.

This separation improves maintainability and makes the application easier to extend.

---

## Key Features Implemented

- Full CRUD operations
- DataGridView data binding
- JSON persistence
- Live search using LINQ
- Patient validation
- Confirmation dialog before deleting records
- Automatic statistics dashboard
- Modular helper methods for improved readability
- Responsive WinForms layout

---

## What I Learned

This project provided practical experience with desktop application development using WinForms and strengthened my understanding of:

- Building desktop applications using C# and .NET
- Designing user interfaces with Windows Forms
- Implementing CRUD operations
- Data binding with DataGridView
- JSON serialisation and local data persistence
- Object-oriented programming principles
- LINQ for searching and filtering collections
- Input validation and business rules
- Separating business logic from the user interface
- Debugging and improving desktop applications

---

## Possible Future Improvements

- SQL Server database integration
- User authentication and role-based access
- Patient appointment scheduling
- Export patient records to PDF or Excel
- Dark mode support
- Advanced filtering and sorting
- Dashboard charts for patient analytics
- REST API integration for cloud-based data storage

---

## Author

**Tats Ndoro**

Bachelor of Computer and Information Sciences (Web Application Development)
