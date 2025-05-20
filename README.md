# Potion Brewery Management System

A desktop application built with WinForms and C# for managing potion recipes, ingredients, and brewing processes. This system is designed for fantasy-themed potion brewing businesses or simulation projects.

## Features

- 🧪 **Recipe Management**  
  - Create, update, and delete potion recipes.
  - Associate recipes with multiple ingredients and required quantities.

- 🌿 **Ingredient Management**  
  - Manage the list of available ingredients.
  - Add, edit, or remove ingredients from the system.

- 🧉 **Potion Brewing**  
  - Simulate brewing potions based on existing recipes.
  - Name your custom brews and define unique attributes.
  - Track brewing history with timestamps.

- 🏠 **Welcome Dashboard**  
  - Central navigation screen to access all major features.

## Technologies Used

- 🧱 **.NET Framework** (WinForms)
- 💾 **Entity Framework** (for data handling)
- 🛢️ **SQL Server / LocalDb** (for database storage)
- 💻 **C#** (language)

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET Framework (recommended 4.7.2+)
- SQL Server Express or LocalDb

### Running the Project

1. Clone the repository or download the source.
2. Open the `.sln` file in Visual Studio.
3. Restore NuGet packages if needed.
4. Ensure your database context is configured and migrated.
5. Set `WelcomeForm` as the startup form:
   - Go to `Program.cs` and make sure it launches `WelcomeForm`.
6. Press `F5` to run.

### Database Setup

Make sure Entity Framework is configured and run migrations if you’re using Code First.

```sh
Update-Database
```

### Authors
- Samuel Reutcky
