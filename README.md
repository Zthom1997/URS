# URS
This Hour registration was part of a schoolproject and is developed in C#.

Background:

The fictional company WeShare needed an application to register the hours of it's employees. WeShare needed
this time registration system because registering hours and paying those worked hours was being done with an
old fashioned time clock. To make it possible for the employees of WeShare to work home, there had to be
developed a new modern time registration system. This system is completely developed on the basis of the
requirements we've received and with the C# language. All data that is being generated is directly stored in
an SQL-database.

General Features:
- Check if an employee has worked more than 60 hours and block the button "Uren Boeken" if this is the case.
- Show different screens for managers and employees with their own privileges.
- Save all data directly into an SQL-database

Features for managers:
- Option to book hours, modify booked hours or delete booked hours
- Option to check all hours from employees that work for a specific manager in a overview window.
- Add, modify or remove employees from the system that are working for a specific manager.
- Option to add new activities on which employees can book hours.
- Option to check the data of the logged-in manager or employee.
- Option to create reports. These reports can be generated for the occupancy rate or for all approved hours
  per employee. The reports are generated based on the data in the database. All reports are automatically
  created in a Word-document.
  
Features for employees:
- Option to book hours, modify booked hours or delete booked hours
- Option to check the data of the logged-in manager or employee.

Note: All screens in this application are in Dutch! The source code is English!
