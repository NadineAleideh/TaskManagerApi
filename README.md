
# Task Manager API

The Task Manager API provides a set of CRUD (Create, Read, Update, Delete) operations for managing tasks. It is built using ASP.NET Core and Entity Framework, providing a robust backend for task management applications.

## Features

- **Create:** Add new tasks to the system.
- **Read:** Retrieve details of existing tasks.
- **Update:** Modify the details of a task.
- **Delete:** Remove tasks from the system.

## Technologies Used

- **ASP.NET Core:** The web framework used for building the API.
- **Entity Framework:** For database access and management.
- **C#:** The primary programming language for the application.
- **Swagger:** API documentation and testing tool.


## Getting Started

Follow these steps to get the Task Manager API up and running on your local machine:

1. **Clone the Repository:**

   Open a terminal or command prompt and run the following command to clone the repository:

   ```bash
   git clone https://github.com/your-username/TaskManagerApi.git
   ```

   Replace `your-username` with your GitHub username.

2. **Navigate to the Project Directory:**

   Move into the project directory using the `cd` command:

   ```bash
   cd TaskManagerApi
   ```

3. **Install Dependencies:**

   Ensure you have [.NET Core](https://dotnet.microsoft.com/download) installed. Then, run the following command to restore the project dependencies:

   ```bash
   dotnet restore
   ```

4. **Run the Application and explore the API as you want.**


## API Endpoints

- `GET /api/tsks`: Retrieve a list of all tasks.
- `GET /api/tsks/{id}`: Retrieve details of a specific task by its ID.
- `POST /api/tsks`: Add a new task.
- `PUT /api/tsks/{id}`: Update the details of a specific task.
- `DELETE /api/tsks/{id}`: Delete a task by its ID.
