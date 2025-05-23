# ASP.NET-Core-WebAPI

This repository contains two ASP.NET Core Web API projects: **Assignment1** and **Assignment2**. Both projects are structured using the Clean Architecture pattern, ensuring separation of concerns and maintainability.

---

## Project Structure

Each project follows a modular architecture with the following layers:

- **Domain**: Contains core business logic and entities.
- **Application**: Implements use cases and application-specific logic.
- **InterfaceAdapters**: Handles communication between the application and external systems.
- **WebApi**: The entry point for the API, containing controllers and configuration.

---
1. **If you need to run test in database**

    ```sh
    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Hung@1234"  -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2022-latest
    ```

> **Note**  
> Assignment 1 use database first, please create database like entity to test
