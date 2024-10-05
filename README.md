# RapidOrder

RapidOrder is an asynchronous order processing system built using .NET Core, RabbitMQ, Angular, and a relational or NoSQL database (configurable). The system is composed of three main parts: a user interface for placing orders, a producer service that publishes orders to RabbitMQ, and a consumer service that processes the orders.

## Table of Contents
- [Overview](#overview)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [System Architecture](#system-architecture)
- [Setup and Installation](#setup-and-installation)
  - [Prerequisites](#prerequisites)
  - [Angular UI Setup](#angular-ui-setup)
  - [.NET Core API Setup](#net-core-api-setup)
  - [RabbitMQ Setup](#rabbitmq-setup)
  - [Database Setup](#database-setup)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Overview
RapidOrder facilitates order placement and processing using a distributed, event-driven architecture. It leverages RabbitMQ for message queuing, making the system scalable and resilient.

- **Producer**: Receives orders via an HTTP API and publishes them to RabbitMQ.
- **Consumer**: Listens to the RabbitMQ queue and processes orders asynchronously (e.g., saving to a database).
- **UI**: A simple Angular-based frontend that allows users to place new orders.

## Project Structure

```
RapidOrder
 ├── RapidOrder.UI          # Angular frontend project (user interface for placing orders)
 ├── RapidOrder.Producer    # .NET Core Web API project (publishes orders to RabbitMQ)
 ├── RapidOrder.Consumer    # .NET Core Worker Service project (consumes and processes orders)
 ├── RapidOrder.Common      # Shared project for configurations, DTOs, RabbitMQ helper functions, and database utilities
 └── README.md              # Project documentation
```

## Technologies Used

- **Frontend**: Angular (TypeScript)
- **Backend**: .NET Core Web API, .NET Core Worker Service
- **Messaging Queue**: RabbitMQ
- **Database**: MySQL, MSSQL, or MongoDB (configurable)
- **Logging**: Serilog/NLog (configurable for file-based logging)
- **Dependency Injection**: Built-in .NET Core DI

## System Architecture

1. **Angular UI**: Users submit orders through a form. The UI communicates with the producer API.
2. **Producer Service**: A .NET Core Web API that accepts the order and publishes it to RabbitMQ.
3. **Consumer Service**: A .NET Core Worker Service that listens for new orders in the RabbitMQ queue, processes them (e.g., inserts into the database), and logs the processing.
4. **Common Library**: Contains shared DTOs, RabbitMQ helper functions, and configurations used by both the producer and consumer services.

![System Architecture](path/to/your-architecture-diagram.png) (Add a diagram if available)

## Setup and Installation

### Prerequisites

Ensure you have the following installed on your local development environment:

- **Node.js & NPM** (for Angular)
- **Angular CLI**: `npm install -g @angular/cli`
- **.NET 6/7 SDK** (for .NET Core projects)
- **RabbitMQ**: [RabbitMQ installation guide](https://www.rabbitmq.com/download.html)
- **MySQL/MSSQL/MongoDB**: (Choose based on your preference)

### Angular UI Setup

1. Navigate to the `RapidOrder.UI` directory:
   ```bash
   cd RapidOrder.UI
   ```

2. Install the Angular dependencies:
   ```bash
   npm install
   ```

3. Run the Angular development server:
   ```bash
   ng serve
   ```

The frontend will be available at `http://localhost:4200`.

### .NET Core API Setup

1. Navigate to the **RapidOrder.Producer** project:
   ```bash
   cd RapidOrder.Producer
   ```

2. Restore the .NET Core dependencies:
   ```bash
   dotnet restore
   ```

3. Run the producer API:
   ```bash
   dotnet run
   ```

The API will be available at `http://localhost:5000/api/orders`.

### RabbitMQ Setup

1. Ensure RabbitMQ is installed and running. You can use Docker to run RabbitMQ:
   ```bash
   docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:management
   ```

2. Access the RabbitMQ management UI at `http://localhost:15672` (default credentials: guest/guest).

3. Create a queue named `orderQueue` for order messages.

### Database Setup

Depending on the database (MySQL, MSSQL, or MongoDB) you want to use:

- **MySQL Setup**:
  - Install MySQL and create a database named `RapidOrderDb`.
  - Update the `appsettings.json` in **RapidOrder.Common** to include the connection string:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=RapidOrderDb;User Id=root;Password=yourpassword;"
      }
    }
    ```

- **MSSQL Setup**:
  - Update `appsettings.json` accordingly for MSSQL.
  
- **MongoDB Setup**:
  - Use the official MongoDB driver and update configurations as needed.

### Consumer Service Setup

1. Navigate to the **RapidOrder.Consumer** project:
   ```bash
   cd RapidOrder.Consumer
   ```

2. Restore the .NET Core dependencies:
   ```bash
   dotnet restore
   ```

3. Run the worker service to start consuming orders:
   ```bash
   dotnet run
   ```

This service will continuously listen to the RabbitMQ queue and process orders as they arrive.

## Usage

1. Start the Angular UI, Producer API, and Consumer service.
2. Open the Angular UI in the browser (`http://localhost:4200`).
3. Submit an order via the form.
4. The producer will send the order to RabbitMQ.
5. The consumer will pick up the message from RabbitMQ and process the order.

## Contributing

Contributions are welcome! If you have suggestions for improving the project, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
