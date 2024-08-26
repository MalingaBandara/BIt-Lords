# BIt-Lords Project

Inventory Management system using C#

## Project Overview

The BIt-Lords project is a C#-based application developed as part of a collaborative learning experience. This group project focuses on building a software solution using the .NET framework and related technologies. The primary goal was to gain hands-on experience in teamwork, version control, and integrating different modules in a C# project.

## Key Features

- **Collaborative Development**: Multiple contributors focused on various aspects of the application.
- **Modular Architecture**: The project is structured to allow easy management of different components.
- **Integration with Version Control**: Leveraged Git and GitHub for effective team collaboration and code management.
- **Learning-Focused**: Built as part of an educational journey to understand C# project development in a team setting.

## Technologies Used

- **C#**
- **.NET Framework**
- **ASP.NET Core**
- **Microsoft SQL Server**
- **Git & GitHub for Version Control**

## Project Structure and Code Explanation

1. **Modular Design**:
   - The project is divided into different modules, each focusing on specific functionality.
   ```csharp
   public class ModuleEntity
   {
       public int Id { get; set; }
       public string Name { get; set; }
       // Other properties and relationships
   }
   ```

2. **Team-Based Development**:
   - Different team members worked on specific modules, which were then integrated into the main project repository.
   - Commit messages and branching strategies reflect collaborative efforts and module integration.

3. **Data Layer**:
   - Utilizes Entity Framework Core for database interactions.
   ```csharp
   public class ModuleRepository : DbContext
   {
       public DbSet<ModuleEntity> Modules { get; set; }
   }
   ```

## Committing Strategy and Learning Insights

The repository follows a structured commit strategy focused on collaboration:
- **Feature-Specific Commits**: Each commit reflects the addition of features specific to a module or functionality.
- **Collaboration Commits**: Multiple commits involve resolving merge conflicts, code integration, and teamwork-focused problem-solving.
- **Documentation and Commenting**: Includes commits focused on enhancing code clarity, documenting modules, and ensuring that the project is well-understood by all team members.

The commit history highlights the importance of collaborative development in real-world projects.

## How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/MalingaBandara/BIt-Lords.git
   ```
2. Set up the SQL Server database and update the configuration files with your settings.
3. Run the application using Visual Studio:
   - Open the solution file in Visual Studio.
   - Restore NuGet packages.
   - Build and run the project.

## Purpose and Future Enhancements

The BIt-Lords project was developed as a team-based learning exercise. Future enhancements could include optimizing existing modules, expanding the application’s functionality, and exploring deployment options on cloud platforms.

