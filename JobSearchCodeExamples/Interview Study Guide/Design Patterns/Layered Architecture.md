# Layered / N-Tier Architecture
 
Layered architecture and N-tier architecture are related 
architectural patterns that organize an application into distinct 
layers or tiers, each with specific responsibilities.

Layered architecture primarily describes logical separation of 
concerns, while N-tier architecture often refers to the physical 
deployment of those layers across separate processes or machines.

### Also known as:
- Layered architecture
- N-Tier architecture
- Three-tier architecture

## Topics
- [Layers](#layers)
- [Real-World Example: Enterprise Accounting Application](#real-world-example-enterprise-accounting-application)
- [Architecture Evolution Example: Distributed to Local Layers](#architecture-evolution-example-distributed-to-local-layers)
- [Language Boundaries Between Layers](#language-boundaries-between-layers)
- [Benefits of This Architecture](#benefits-of-this-architecture)
- [Architectural Principle](#architectural-principle)
- [Lessons Learned](#lessons-learned)
- [Common Interview Questions](#common-interview-questions)
- [My Experience with Layered / N-Tier Architecture](#my-experience-with-layered--n-tier-architecture)
- [Related Topics](#related-topics)
 
## Layers
1. **Presentation Layer (UI Layer)**: Responsible for handling user 
interactions and displaying information. It communicates with the 
business logic layer to process user requests.
2. **Application / Service Layer**: Acts as an intermediary between 
the presentation layer and the business logic layer. It coordinates
requests, manages transactions, and provides services to the 
presentation layer. This layer is optional and may be omitted in 
simpler applications, allowing the presentation layer to communicate 
directly with the business logic layer.
3. **Business Logic Layer (BLL)**: Contains the core functionality 
and business rules of the application. It processes data received 
from the presentation layer and interacts with the data access layer.
4. **Data Access Layer (DAL)**: Manages data persistence and 
retrieval from databases or other storage systems. It abstracts 
the underlying data sources and provides a consistent interface 
for the business logic layer.
5. **Database Layer**: The actual database or storage system where 
data is stored and managed.

## Real-World Example: Enterprise Accounting Application
The Cougar Mountain Software Denali application follows an N-tier 
architecture. The system is divided into multiple layers, with each 
layer having specific responsibilities and limited knowledge of the 
layers below it.

### Presentation Layer
The presentation layer contains the user-facing applications and is 
responsible for displaying information to the user and collecting 
user input.

Responsibilities:
- User interface
- User interaction
- Displaying business data
- Managing UI state

The presentation layer does not directly communicate with the 
database.

### Application / Service Layer
The application layer coordinates work between the user interface 
and the business logic layer.

Responsibilities:
- Printing reports
- Integrating with third-party APIs
- Coordinating business operations
- Providing services to the presentation layer

This layer does not directly access SQL Server.

### Business Logic and Data Layer
The business logic layer contains the rules and processes that 
define how the application operates.

Responsibilities:
- Business rules
- Data validation
- Processing accounting operations
- Managing communication with SQL Server
- Data access operations

The layers above do not need to know how data is stored or 
retrieved.

### Database Layer
The database layer contains the SQL Server database and is 
responsible for persisting application data.

Responsibilities:
- Data storage
- Queries
- Transactions
- Data integrity

## Architecture Evolution Example: Distributed to Local Layers
The Denali application was originally designed as a distributed 
N-Tier application. The business logic layer could be hosted in 
COM+ on a separate machine, allowing the presentation layer to 
communicate with business logic across a network boundary.

The architecture was structured as:

```
Presentation Layer
        |
        v
Application / Business Services
        |
        v
Business Logic + Data Access
        |
        v
SQL Server
```

### Original Architecture
The business logic components were hosted in COM+ and could execute
either locally or on a separate machine. This provided physical
separation between layers while allowing business processing to 
occur on dedicated application servers.

This architecture kept the presentation layer thin and focused on 
user interaction, while the business logic layer handled business 
rules, complex processing, and data access.

It also allowed the presentation layer to run on less powerful 
client hardware while the business logic executed on faster, more 
capable application servers.

### Architecture Simplification
At the time the system was designed, distributing business logic 
across application servers was a common enterprise architecture. As 
hardware became significantly more powerful and affordable, and 
maintaining COM+ became increasingly difficult, the physical 
separation no longer provided enough benefit to justify its 
complexity.

However, the logical separation between layers remained unchanged.

The benefits of maintaining the layered design included:

- The UI did not need to know database details.
- Business rules remained centralized.
- Data access code remained isolated.
- Future presentation technologies could reuse existing business 
logic.

### Adding a New Presentation Layer
A newer web-based user interface was developed by replacing only 
the presentation layer. The underlying business logic and data 
access layers continued to be reused.

This demonstrates one of the primary benefits of layered 
architecture: presentation technologies can change without 
requiring a complete rewrite of business functionality.

## Language Boundaries Between Layers
One interesting aspect of the Denali architecture is that the 
layers are not required to use the same programming language.

The presentation layer is implemented using C# and C++, while the 
lower business logic and data access layers are implemented using 
VB.NET.

Because the layers communicate through defined interfaces and 
contracts, the presentation technology does not need to know how 
the underlying business logic is implemented.

This allowed:
- Different teams to work in different languages.
- UI technologies to evolve independently from business logic.
- Existing business rules to be reused by newer applications.

## Benefits of This Architecture
- Separation of concerns
- Easier maintenance
- Improved testability
- Ability to change one layer without rewriting the entire 
application
- Clear ownership of responsibilities

## Architectural Principle
A well-designed layered architecture depends on contracts between 
layers, not on implementation details.

The presentation layer depends on the services provided by the 
business layer, but it does not depend on the language, internal 
classes, or database implementation used by that layer.

This principle aligns with the Dependency Inversion Principle (DIP),
where higher-level business rules should not depend directly on 
lower-level implementation details.

## Lessons Learned

One of the original goals of the Denali architecture was to isolate each
major layer so that it could be replaced independently.

This goal was largely achieved for the presentation layer. Over time,
new user interfaces were able to reuse the existing business logic
without requiring significant changes to the lower layers.

Replacing the data layer, however, proved to be much more difficult.
Although the system logically separated business logic from data access,
many business operations were closely tied to SQL Server and the existing
database schema. As a result, changing the underlying persistence
technology would require substantial refactoring.

This experience reinforced an important architectural lesson:

> Separating layers is easier than separating responsibilities.

Well-defined interfaces and dependencies make replacing components much
more practical than simply organizing code into different projects or
assemblies.

## Common Interview Questions
**How would you explain the difference between a layered 
architecture and a three-tier architecture?**

Layered architecture describes the logical separation of 
responsibilities. Three-tier architecture usually refers to 
physically separated tiers (presentation server, application 
server, database server).

A system can be layered without being physically distributed.

**What are the disadvantages of layered architecture?**

Potential disadvantages include:
- Additional complexity
- More code boundaries to maintain
- Potential performance overhead from crossing layers
- Risk of creating unnecessary abstractions

**Why would you choose a layered architecture?**

Layered architecture provides clear separation of responsibilities,
making systems easier to understand, maintain, test, and modify.
It allows parts of the system to evolve independently as long as
the contracts between layers remain stable.

## My Experience with Layered / N-Tier Architecture
I have worked extensively with the Cougar Mountain Software Denali
application, which uses a layered N-Tier architecture.

The system separates:
- Presentation/UI responsibilities
- Application services
- Business logic
- Data access
- SQL Server persistence

The original architecture allowed business logic components to run 
remotely using COM+. As hardware became more powerful and 
maintaining COM+ became more complex, the physical separation was 
removed while maintaining the logical layer boundaries.

This architecture allowed new presentation technologies, including a 
web-based UI, to reuse existing business logic and data access 
components without rewriting the underlying application.

The presentation layer was implemented using C# and C++, while the
business logic and data access layers were implemented using VB.NET.
The architecture allowed these technology boundaries to coexist 
without requiring the layers to share implementation details.

## Related Topics
- Clean Architecture
- SOLID Principles
- Dependency Injection
- Separation of Concerns
- Repository Pattern
- Unit Testing
- Microservices
- MVC
- MVVM