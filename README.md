# ProjectIdeas - WPF Desktop Application

## Overview

**ProjectIdeas** is a desktop application built with WPF and .NET Core, designed to assist users in generating, managing, and maintaining ideas for software projects. The application leverages MVVM architecture and fluent page navigation, integrated with Dependency Injection (DI) for a robust and maintainable codebase.

## Project Aims

* **Idea Generation:** Integrate ChatGPT API to dynamically generate innovative project ideas.
* **Project Management:** Efficiently store and manage current project ideas and details.
* **User Experience:** Provide a seamless and intuitive navigation experience using fluent UI controls and MVVM.
* **Logging and Debugging:** Comprehensive logging implemented with Serilog for easy debugging and auditing.

## Technology Stack

* **Framework:** .NET Core with WPF
* **Architecture:** MVVM (Model-View-ViewModel)
* **Dependency Injection:** Implemented for maintainability and scalability using `WPF-UI.DependencyInjection`
* **Entity Framework Core:** SQLite for efficient and reliable local storage
* **Logging:** Serilog with structured logging to file
* **UI/UX:** Fluent UI styling provided by `WPF-UI`

## Current Implementation Status

### Completed

* Basic WPF application setup with MVVM architecture
* Fluent page navigation using `WPF-UI`
* Dependency Injection fully implemented
* Initial Serilog logging configured (console and file sinks)
* Application settings configuration setup

### Upcoming Features

* **Pages Setup:** Implementation of detailed functionality across:

  * **About Page:** Providing app version, developer info, and licensing details.
  * **New Project Page:** Interface for generating new project ideas.
  * **Project Table Page:** Display and manage existing projects.
  * **Settings Page:** Managing app settings, preferences, and configurations.
* **Entity Framework Core Integration:** Complete SQLite integration for robust database management.
* **ChatGPT API Integration:** Implement API calls to generate project ideas based on user inputs.
* **Advanced Logging:** Enhance Serilog implementation for detailed structured logging.
* **Robust App Settings:** Extended management for API keys, themes, and user preferences.
* **UI Styling:** Further refinement and enhancement of existing Fluent UI elements across all pages for improved user experience.

## Getting Started

### Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Visual Studio](https://visualstudio.microsoft.com/) or similar IDE

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/yourusername/ProjectIdeas.git
   ```

2. Navigate to the project folder:

   ```sh
   cd ProjectIdeas
   ```

3. Restore dependencies:

   ```sh
   dotnet restore
   ```

4. Run the application:

   ```sh
   dotnet run
   ```

