# Simple Expense Tracker (Winform.NET 6)

## Table of Contents
1. [Summary](#summary)
2. [Project Idea Description](#project-idea-description)
3. [Core Features](#core-features)
4. [Usage Instructions](#usage-instructions)
5. [Development Approach](#development-approach)
6. [Tools and Libraries](#tools-and-libraries)

## Summary
The Expense Tracker (Winform.NET 6) is a desktop application designed to help individuals manage and track their daily expenses. It provides a user-friendly interface for recording, viewing, and analyzing expenses over time.

## Project Idea Description
The Expense Tracker offers a simple yet effective solution for users who want better control and understanding of their expenses. It allows users to record individual expenses, view expense records, generate reports, and securely manage their data through user authentication.

## Core Features
- **Expense Recording**: Users can record individual expenses by entering details like amount, category, and date.
- **Expense Viewing and Searching**: Users can view a list of expenses and search for specific expenses based on category.
- **Reports of Expense Data**: Users can view simple reports, including maximum and minimum expense amounts, category-wise expenses, etc.
- **User Authentication**: Users can create personal accounts with secure passwords to manage their expenses.
- **Database Management**: The application uses a lightweight backend database (SQL Server Express) to store and manage user data.

## Usage Instructions
### Running App:
1. Clone the repository.
2. Open the corresponding folder.
3. Build and run the application in Visual Studio 2022.

### Logging Screen:
- Enter your username and password to log in.
- Admin users can manage user accounts and expenses (password:adminpass).

### MainMenu Screen:
- Add Expense: Record new expenses.
- View Expense: View recorded expenses and filter by category.
- Reports: View analytics of recorded expenses.
- Log out: Return to the login screen.

## Development Approach
- **Requirements Gathering and Analysis**: Documented functional and non-functional requirements.
- **Database Design**: Utilized SQL Server Express for the backend database and designed an efficient schema.
- **Back-end Development**: Implemented database interactions using Microsoft's System.Data.SqlClient and incorporated error handling.
- **Front-end Development**: Developed using WinForms in .NET 6, ensuring a modern interface with various forms and controls.
- **User Authentication**: Designed a simple authentication system for user account management.
- **Testing and Debugging**: Conducted unit testing and debugging to ensure functionality.
- **Optimization**: Optimized queries and code for performance and adhered to best practices.
- **Documentation and Deployment**: Documented code and packaged the application for deployment using Visual Studio 2022 Publish feature.

## Tools and Libraries
- **Visual Studio 2022**: Primary IDE for coding, testing, and debugging.
- **SQL Server Express**: Backend database for storing user data.
- **LINQ**: Used for data querying capabilities.
- **.NET 6**: Modern framework facilitating the development of a robust application.
