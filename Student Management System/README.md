# 🎓 Student Management System - C# Console Application

This is a simple yet fully functional **Student Management System** built using **C#**. It follows an object-oriented approach and allows users to **add**, **view**, **search**, **update**, **delete**, **sort**, and **filter** student records via a console-based interface.

---

## 📌 Features

- ➕ Add new students
- 📋 Display all students
- 🔍 Search for a student by ID
- 📝 Update student information
- ❌ Delete a student
- 🔡 Sort students by name
- 🎯 Filter students by grade
- 💾 Save data to a text file
- ⚠️ Exception handling for robust error management

---

## 🛠 Skills & Concepts Used

| Skill/Concept             | Functionality in Project |
|--------------------------|---------------------------|
| 🔹 **Classes & Objects** | Used to model students and handle logic (`Student`, `StudentManager`) |
| 🔹 **Encapsulation**     | All properties are private with public getters/setters |
| 🔹 **Properties**        | Manage student data like `Name`, `Age`, `Id`, and `Grade` |
| 🔹 **Enums**             | Represent fixed grade levels (`A`, `B`, `C`, `F`) |
| 🔹 **Lists (Generics)**  | Store and manage a dynamic collection of students |
| 🔹 **LINQ**              | Used for searching, sorting, and filtering students |
| 🔹 **Custom Exceptions** | `NoValidDataFoundedException` used for better error messaging |
| 🔹 **File Handling**     | Appends student data to a `.txt` file using `FileStream` and `StreamWriter` |
| 🔹 **Exception Handling**| Try-Catch blocks around all risky operations |
| 🔹 **ToString() Override** | Custom print format for displaying student data |
| 🔹 **Console I/O**       | Takes user input and displays results on the console |

---

## 🧠 Technologies Used

- 👨‍💻 C# (.NET Console App)
- 📂 FileStream & StreamWriter for file operations
- 🧪 Custom Exception Handling
- 📊 Collections and LINQ

---

## 🏗️ Project Structure


Student_Management_System/ │ ├── Program.cs # Entry point with menu system ├── Student.cs # Student class with encapsulation & ToString() ├── StudentManager.cs # All core business logic (CRUD, Sort, Filter) ├── StudentData.txt # Stores student records (appended) └── README.md # You're reading it now!

---

## 🚀 How to Run

1. **Clone this repository:**
   ```bash
   git clone https://github.com/your-username/student-management-system.git
   cd student-management-system
2. **Open in Visual Studio or VS Code**

3. **Build & Run the application**

---
## 🪄 Future Improvements (Ideas) ##

- Implement file reading on application start

- Export records to CSV

- Add UI using Windows Forms / WPF

- Add database support using SQL Server or SQLite

- Create a Web API version using ASP.NET Core

