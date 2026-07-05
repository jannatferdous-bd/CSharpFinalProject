# CSharpFinalProject - Customer Management System

A professional .NET Core console application demonstrating advanced software design patterns and clean architecture principles. This project showcases the implementation of the **Factory Pattern** and **Repository Pattern** in C# to build a scalable and easily maintainable customer management system.

##  Architectural Highlights

*   **Factory Pattern:** Utilized to encapsulate the creation logic of different customer types (e.g., Regular, New), ensuring the system follows the Open/Closed Principle (OCP).
*   **Repository Pattern:** Implemented to decouple the business logic layer from the data access layer, allowing clean data manipulation and prepared structures for future database integration.
*   **Decoupled Interfaces:** Comprehensive use of interfaces (`ICustomerRepo`, `ICustomerManager`, etc.) to enforce strict contracts and enable easy unit testing.

##  Project Structure

*   `Entities/` - Contains core core business models (e.g., `Customer.cs`).
*   `Enums/` - Holds system-wide enumerations like `CustomerType.cs`.
*   `Interfaces/` - Defines system abstraction contracts for Repositories and Managers.
*   `Factory/` - Implements the Factory Method Pattern for dynamic object instantiation.
*   `Manager/` - Handles core business rules and orchestration logic.
*   `Repositories/` - Manages data operations and state simulation.

##  Technologies & Tools Used

*   **Language:** C#
*   **Framework:** .NET Framework / .NET Core
*   **Patterns:** Factory Method, Repository Pattern
*   **Version Control:** Git & GitHub

##  How to Run

1. Clone the repository:
   ```bash
   git clone [https://github.com/jannatferdous-bd/CSharpFinalProject.git](https://github.com/jannatferdous-bd/CSharpFinalProject.git)
