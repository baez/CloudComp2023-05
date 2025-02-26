# CloudComp2023-05

CloudComp2023-05 is a C# project developed to explore and experiment with cloud computing concepts and services. This repository serves as a sandbox for testing various cloud-based solutions, focusing on Azure Functions, data modeling, and service-oriented architecture.

## Features

- **Azure Functions Experiments**: Implementations of serverless functions to understand event-driven execution in the cloud.
- **Data Modeling**: Creation and testing of data models to structure and manage information effectively.
- **Service-Oriented Architecture**: Development of services like `CustomerQueue` and `RequestQueueService` to handle asynchronous operations.
- **Unit Testing**: Incorporation of test projects to ensure code reliability and performance.

## Project Structure

- `CustomerQueue/`: Manages customer-related queuing mechanisms.
- `DataModelTests/`: Contains unit tests for validating data models.
- `DataModels/`: Defines the structure of data entities used across the project.
- `ExperimentAzFunc1/`: Houses experimental Azure Function implementations.
- `Interfaces/`: Declares interfaces to promote code modularity and testability.
- `Lessons/`: Documents insights and learnings acquired during the experimentation process.
- `Repositories/`: Implements data access layers following repository patterns.
- `RequestQueueServiceTests/`: Contains unit tests for the `RequestQueueService` component.
- `.gitattributes` & `.gitignore`: Configuration files for Git version control.
- `CloudComp2023-05.sln`: Visual Studio solution file for managing the project.

## Getting Started

### Prerequisites

- .NET SDK installed
- Visual Studio or another compatible C# IDE
- Azure subscription (for deploying and testing Azure Functions)
- Git (optional, for cloning the repository)

### Installation & Setup

1. **Clone the repository:**

   ```bash
   git clone https://github.com/baez/CloudComp2023-05.git
   ```

2. **Open the solution file:**

   Navigate to the project directory and open `CloudComp2023-05.sln` in Visual Studio.

3. **Restore dependencies and build the solution:**

   Use Visual Studio's build feature to restore NuGet packages and compile the project.

4. **Run the application:**

   Execute the application or individual components using Visual Studio's debugging tools.

## Purpose and Learnings

This project was created to delve into:

- **Serverless Computing:** Gaining hands-on experience with Azure Functions to build scalable, event-driven applications without managing infrastructure.
- **Cloud-Based Data Management:** Understanding how to model, store, and retrieve data in a cloud environment.
- **Asynchronous Processing:** Implementing queue-based systems to handle tasks asynchronously, improving application responsiveness and scalability.
- **Testing in the Cloud:** Applying unit testing practices to ensure the reliability of cloud-based services and functions.

## License

This project is licensed under the Apache License 2.0.

---

For any inquiries or collaboration opportunities, feel free to reach out!

