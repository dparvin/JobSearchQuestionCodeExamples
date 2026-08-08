# Dependency Injection Guide

Dependency Injection (DI) is a design pattern that allows for the 
decoupling of dependencies in an application. It promotes the 
principle of Inversion of Control (IoC), where the control of 
object creation and dependency management is transferred from the 
class itself to an external entity, typically a DI container.

## Topics
- [Why Dependency Injection Exists](#why-dependency-injection-exists)
- [What is Dependency Injection?](#what-is-dependency-injection)
- [Dependency Injection vs Inversion of Control](#dependency-injection-vs-inversion-of-control)
- [Benefits of Dependency Injection](#benefits-of-dependency-injection)
- [Types of Dependency Injection](#types-of-dependency-injection)
- [Implementing Dependency Injection in .NET](#implementing-dependency-injection-in-net)
- [Example](#Example)
- [Common Mistakes](#common-mistakes)
- [Common Interview Questions](#common-interview-questions)
- [My Experience with Design Patterns](#my-experience-with-design-patterns)
- [Related Topics](#related-topics)

## Why Dependency Injection Exists

Without dependency injection, classes often create the objects they need
directly. This tightly couples the class to specific implementations,
making the code difficult to test and maintain.

Dependency Injection moves the responsibility of creating dependencies
to another part of the application, allowing classes to depend on
abstractions instead of concrete implementations.

## What is Dependency Injection
Dependency Injection is a design pattern that allows for the 
decoupling of dependencies in an application. It promotes the 
principle of Inversion of Control (IoC), where the control of 
object creation and dependency management is transferred from 
the class itself to an external entity, typically a DI container. 
This allows for greater flexibility, testability, and maintainability 
of the codebase. 

## Dependency Injection vs Inversion of Control

Inversion of Control (IoC) is a general design principle where a class
gives up control over some aspect of its behavior.

Dependency Injection is one way of implementing IoC by supplying
dependencies from the outside instead of constructing them internally.

All Dependency Injection is IoC, but not all IoC is Dependency Injection.

## Benefits of Dependency Injection
- **Flexibility**: Dependencies can be easily swapped or modified without changing the class that uses them.
- **Testability**: It's easier to write unit tests by injecting mock dependencies.
- **Maintainability**: Code becomes easier to maintain and extend as dependencies are clearly defined and managed.

## Types of Dependency Injection
- **Constructor Injection**: Dependencies are provided through the class constructor.
- **Property Injection**: Dependencies are provided through public properties.
- **Method Injection**: Dependencies are passed as parameters to methods.

## Implementing Dependency Injection in .NET

The Microsoft.Extensions.DependencyInjection package provides a built-in
dependency injection container.

Services are typically registered during application startup.

Examples:

- AddSingleton<T>()
- AddScoped<T>()
- AddTransient<T>()

Constructor injection is the preferred technique and is supported
automatically by ASP.NET Core.

## Example

### Without Dependency Injection
In this example, `OrderService` creates its own repository. This tightly
couples the service to a specific implementation and makes it difficult
to unit test.

```csharp
public class OrderService
{
    private readonly SqlOrderRepository _repository =
        new SqlOrderRepository();

    public void Save(Order order)
    {
        _repository.Save(order);
    }
}
```

### With Dependency Injection
Instead of creating the repository directly, the dependency is supplied
through the constructor.

```csharp
public class OrderService
{
    private readonly IOrderRepository _repository;

    public OrderService(IOrderRepository repository)
    {
        _repository = repository;
    }

    public void Save(Order order)
    {
        _repository.Save(order);
    }
}
```

Now `OrderService` no longer depends on a specific implementation.
Any class implementing `IOrderRepository` can be supplied, including
mock objects used for unit testing.

### Registering Services
```csharp
builder.Services.AddScoped<IOrderRepository, SqlOrderRepository>();
builder.Services.AddScoped<OrderService>();
```

### Constructor Injection
```csharp
public class OrderController
{
    private readonly OrderService _service;

    public OrderController(OrderService service)
    {
        _service = service;
    }
}
```

### Property Injection Example
Property injection provides dependencies through a public property instead
of the constructor.

```csharp
public class OrderService
{
    public IOrderRepository? Repository { get; set; }

    public void Save(Order order)
    {
        Repository?.Save(order);
    }
}
```

The dependency is assigned after the object is created.

```csharp
var service = new OrderService();

service.Repository = new SqlOrderRepository();

service.Save(order);
```

Property injection can be useful when a dependency is optional or when the
dependency may need to be changed after object construction. However,
constructor injection is usually preferred because it ensures that required
dependencies are provided when the object is created and prevents the object
from being placed into an invalid state.

### Method Injection Example
Method injection provides dependencies as parameters to a method.

```csharp
public class ReportGenerator
{
    public void GenerateReport(IReportFormatter formatter)
    {
        formatter.Format();
    }
}
```

This is useful when a dependency is only needed for a single operation
rather than for the lifetime of the object.

## Common Mistakes
- Injecting too many dependencies into one class.
- Registering services with the wrong lifetime.
- Using the service locator pattern instead of constructor injection.
- Injecting concrete classes instead of interfaces.

## Common Interview Questions
- **What problem does DI solve?** Dependency Injection reduces coupling 
by allowing a class to depend on abstractions rather than concrete 
implementations. This improves maintainability, flexibility, and 
testability because dependencies can be substituted without modifying 
the consuming class.  

- **Constructor vs property injection?** The main reason to do one of 
these over the other is that constructor injection makes it impossible 
to create an instance of a class without providing the required 
dependencies, ensuring that the class is always in a valid state. 
Property injection allows for optional dependencies and can be useful 
when you want to set or change dependencies after the object has been 
constructed.

- **What are Singleton, Scoped, and Transient lifetimes in DI?** 
  - **Singleton**: A single instance is created and shared throughout 
  the application's lifetime.
  - **Scoped**: A new instance is created for each scope, typically 
  per web request in web applications.
  - **Transient**: A new instance is created every time it is requested.

## My Experience with Dependency Injection
- Using constructor injection in several .NET application to reduce 
coupling between business logic and infrastructure.
- Replaced direct object creation with interfaces to improve 
unit testablility.
- Removed dependencies on Microsoft Fakes by introducing interfaces 
and injecting implementations during testing.

## Related Topics
- SOLID principles
- Inversion of Control (IoC)
- Unit Testing
- ASP.NET Core
- Design Principles