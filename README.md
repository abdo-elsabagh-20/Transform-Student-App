🚌 Student Bus Management System
📌 Project Overview

The Student Bus Management System is a Windows Forms application developed using C#, SQL Server, and ADO.NET. The system is designed to manage student transportation by organizing students, buses, drivers, areas, and subscriptions in a centralized database.

The application provides a user-friendly interface that allows administrators to perform all essential operations such as adding, updating, deleting, and viewing records while maintaining relationships between different entities.

🎯 Project Objectives
Manage student information.
Manage buses and their routes.
Manage drivers and assign them to buses.
Manage service areas.
Manage student subscriptions and payment status.
Assign students to buses.
Maintain data integrity using relational database concepts.
🏗️ Technologies Used
Programming Language: C#
Framework: .NET Windows Forms
Database: SQL Server
Data Access: ADO.NET
IDE: Visual Studio
📊 Database Structure
1. Students

Stores student information.

Field	Description
Student_ID	Unique student ID
Name	Student name
Phone	Student phone number
Address	Student address
2. Buses

Stores bus information.

Field	Description
Bus_ID	Unique bus ID
Capacity	Bus capacity
Route	Bus route
Driver_ID	Assigned driver
Area_ID	Assigned area
3. Drivers

Stores driver information.

Field	Description
Driver_ID	Unique driver ID
Name	Driver name
Phone	Driver phone number
4. Areas

Stores service areas.

Field	Description
Area_ID	Unique area ID
Area_Name	Area name
5. Subscriptions

Stores student subscription information.

Field	Description
Sub_ID	Unique subscription ID
Student_ID	Student reference
Payment_Status	Paid / Not Paid
Date	Subscription date
6. StudentBus

Junction table used to assign students to buses.

Field	Description
Student_ID	Student reference
Bus_ID	Bus reference
🔗 Relationships
One Driver ➜ Many Buses
One Area ➜ Many Buses
One Student ➜ Many Subscriptions
Many Students ↔ Many Buses (through StudentBus)
🖥️ Application Modules
🏠 Main Dashboard
Navigation panel.
Access to all system modules.
Centralized application control.
👨‍🎓 Students Management
Add new students.
Update student information.
Delete students.
View all students.
🚌 Buses Management
Add buses.
Update bus information.
Delete buses.
Assign drivers and areas to buses.
👨‍✈️ Drivers Management
Add drivers.
Update driver information.
Delete drivers.
📍 Areas Management
Add service areas.
Update area information.
Delete areas.
💳 Subscription Management
Create subscriptions.
Update payment status.
View subscription records.
Track payment history.
🔄 Student-Bus Assignment
Assign students to buses.
View all student-bus assignments.
Manage transportation allocations.
⚙️ Features
Full CRUD Operations (Create, Read, Update, Delete).
Relational database implementation.
Data validation.
User-friendly Windows Forms interface.
SQL Server integration.

🚀 Future Enhancements
Login and Authentication System.
Role-Based Access Control.
Search and Filtering Features.
Reports and Statistics.
Export Data to Excel/PDF.
Notification System for Expired Subscriptions.
Dashboard Analytics and Charts.
👨‍💻 Author
Omnia Ismail Ahmed Ahmed
Kholoud Elsayed Youssef Elsayed
Abdelrahman Abdelhamid Khamis
Alaa Khaled Abdelsalam Elsayed
Omar Mohamed Elmetwally Saleh


Student Bus Management System – Database Project using C#, SQL Server, and Windows Forms.
Dynamic ComboBox data loading.
DataGridView record management.
Centralized navigation system.
