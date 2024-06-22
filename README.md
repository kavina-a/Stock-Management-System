# Stock Management System

This Stock Management System is developed using C# and integrates with a XAMPP database. The system is designed to manage stock efficiently by enabling the addition of new stock items and updating stock quantities while maintaining a detailed transaction log. This README file provides an overview of the system, its features, setup instructions, and additional information to help users and developers understand and use the system.

## Features

### 1. Adding New Stock Items
- **Feature Description**: Allows users to add new stock items by capturing essential information such as stock code, name, and quantity.
- **Transaction Logging**: Each addition is recorded in a transaction log for auditing and tracking purposes.
- **Database Integration**: New stock items are stored in the stock database for easy retrieval and management.

### 2. Updating Stock Quantities
- **Feature Description**: Enables users to update the quantities of existing stock items.
- **Transaction Logging**: Each update is logged to maintain a historical record of all stock changes.
- **Database Integration**: Updates are reflected in the stock database to ensure accurate stock levels.

### 3. Advanced Error Handling
- **Robust Error Handling**: The system includes advanced error handling to manage exceptions and ensure smooth operation.
- **User Notifications**: Provides meaningful error messages to users for better understanding and troubleshooting.

## Setup Instructions

### Prerequisites
- **XAMPP**: Ensure you have XAMPP installed and running on your machine.
- **C# Development Environment**: Visual Studio or any other C# IDE.

### Database Setup
1. **Start XAMPP**: Launch the XAMPP control panel and start the Apache and MySQL services.
2. **Create Database**: Open phpMyAdmin and create a new database named `stock_management`.
3. **Import Database Schema**: Use the provided SQL file (`database/schema.sql`) to create the necessary tables.

### Application Setup
1. **Clone the Repository**: Clone this repository to your local machine using `git clone <repository_url>`.
2. **Open Solution**: Open the solution file (`StockManagementSystem.sln`) in your C# IDE.
3. **Configure Database Connection**: Update the database connection string in the `appsettings.json` or configuration file with your XAMPP database credentials.
4. **Build and Run**: Build the solution and run the application.


## Error Handling
- The system includes advanced error handling to manage common and uncommon issues.
- User-friendly error messages are displayed to assist in troubleshooting.

## Contribution
If you would like to contribute to this project, please fork the repository and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

## Contact
For any questions or feedback, please contact [kmanthuka@gmail.com].


