# Stock-Management-System

Stock Management System - 1st Year 2nd Semester - APIIT

This Stock Management System is developed using C# and integrates with a XAMPP database. The system is designed to manage stock efficiently by enabling the addition of new stock items and updating stock quantities while maintaining a detailed transaction log. This README file provides an overview of the system, its features, setup instructions, and additional information to help users and developers understand and use the system.

##Features
###1. Adding New Stock Items
Feature Description: Allows users to add new stock items by capturing essential information such as stock code, name, and quantity.
Transaction Logging: Each addition is recorded in a transaction log for auditing and tracking purposes.
Database Integration: New stock items are stored in the stock database for easy retrieval and management.

###3. Updating Stock Quantities
Feature Description: Enables users to update the quantities of existing stock items.
Transaction Logging: Each update is logged to maintain a historical record of all stock changes.
Database Integration: Updates are reflected in the stock database to ensure accurate stock levels.

###5. Advanced Error Handling
Robust Error Handling: The system includes advanced error handling to manage exceptions and ensure smooth operation.
User Notifications: Provides meaningful error messages to users for better understanding and troubleshooting.

Setup Instructions

Prerequisites
XAMPP: Ensure you have XAMPP installed and running on your machine.
C# Development Environment: Visual Studio or any other C# IDE.
Database Setup
Start XAMPP: Launch the XAMPP control panel and start the Apache and MySQL services.
Create Database: Open phpMyAdmin and create a new database named stock_management.
Import Database Schema: Use the provided SQL file (database/schema.sql) to create the necessary tables.
Application Setup
Clone the Repository: Clone this repository to your local machine using git clone <repository_url>.
Open Solution: Open the solution file (StockManagementSystem.sln) in your C# IDE.
Configure Database Connection: Update the database connection string in the appsettings.json or configuration file with your XAMPP database credentials.
Build and Run: Build the solution and run the application.
Usage
Adding New Stock Items
Navigate to the "Add New Stock" section.
Enter the stock code, name, and quantity.
Click the "Add" button to save the new stock item. The item will be added to the stock database and logged in the transaction log.
Updating Stock Quantities
Navigate to the "Update Stock" section.
Enter the stock code and the new quantity.
Click the "Update" button to save the changes. The quantity will be updated in the stock database and logged in the transaction log.

Error Handling
The system includes advanced error handling to manage common and uncommon issues.
User-friendly error messages are displayed to assist in troubleshooting.

Contribution
If you would like to contribute to this project, please fork the repository and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

License
This project is licensed under the MIT License. See the LICENSE file for more details.

Contact
For any questions or feedback, please contact [your-email@example.com].

