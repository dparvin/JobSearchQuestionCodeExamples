# Evolution of Enterprise Software

## Overview

Enterprise software has evolved significantly as hardware, operating
systems, programming languages, databases, networking, and development
practices have changed.

My experience spans the transition from file-based DOS applications
running on floppy disks to modern .NET applications using SQL Server,
web applications, APIs, automated testing, and modern deployment
practices.

This page documents some of the technologies and architectural approaches
I have worked with and the lessons I learned as those technologies evolved.

## Topics

- [Early File-Based Systems](#early-file-based-systems)
- [DOS and QuickBasic](#dos-and-quickbasic)
- [Visual Basic and dBase](#visual-basic-and-dbase)
- [The Transition to .NET and SQL Server](#the-transition-to-net-and-sql-server)
- [Distributed Enterprise Applications](#distributed-enterprise-applications)
- [Modernizing the Architecture](#modernizing-the-architecture)
- [Replacing the Presentation Layer](#replacing-the-presentation-layer)
- [Lessons Learned](#lessons-learned)
- [Technology Evolution](#technology-evolution)
- [Interview Questions](#interview-questions)

## Early File-Based Systems
Early business applications often had to operate with extremely 
limited hardware and storage resources. Database management systems 
were not always available or practical, so applications frequently 
managed their own data files and indexing structures.

## DOS and QuickBasic
After graduating from high school in 1982, I worked with my father 
on an order entry and inventory control system written in QuickBasic.

The application ran under DOS and stored its data in random-access 
files on floppy disks. It did not use a database management system.

Because disk access was slow, the application required carefully 
designed data structures to provide acceptable performance.

### Custom Inventory Index

The inventory system used a custom multi-level indexing scheme.

The index consisted of 1,000 records. The last four digits of a stock
number were used to select an entry in the index. Each index entry
identified the starting point of a binary tree containing inventory
records associated with that index value.

The lookup process was approximately:

```
Stock Number
    |
    v
Last Four Digits
    |
    v
1,000-Entry Index
    |
    v
Binary Tree
    |
    v
Inventory Record
```

On older hardware using floppy drives, this allowed most inventory
lookups to complete in under two seconds.

### Lessons From File-Based Systems

This experience taught me that performance is not solely determined 
by hardware. Data structures and algorithms can have an enormous 
impact on the performance of an application, particularly when the 
underlying storage system is slow.

## Visual Basic and dBase
When I started at Cougar Mountain Software in 1996, the company was 
using Visual Basic 3 to develop its accounting software, and dBase 
files for data storage. The company was simultaneously maintaining 
the existing DOS-based accounting software while developing the 
newer Windows-based product.  The DOS product was retired in 1999, 
but some customers continued using it for many years afterward. Some 
customers were eventually forced to upgrade when it became difficult 
or impossible to obtain hardware that could run the DOS software.

This represented a significant change from the earlier DOS 
applications. Development tools were becoming more sophisticated, 
while file-based databases provided more structure for managing 
business data.

An attempt was later made to rewrite the application using Visual 
Basic 6. The rewrite proved more difficult than expected, and 
development continued using the existing Visual Basic technology.

## The Transition to .NET and SQL Server
The next major architectural transition was the development of the
Denali accounting system.

Development began in the early 2000s using technologies including:

- MFC C++
- VB.NET
- SQL Server 2000

The system was designed as a layered N-Tier application, separating 
the user interface, business logic, data access, and database 
responsibilities.  The earlier modules were primarily implemented 
using VB.NET and MFC C++. For the final two modules, Payroll and 
Job Cost, development shifted toward C# for the UI components.  
The database platform was subsequently upgraded from SQL Server 2000 
to SQL Server 2005, then SQL Server 2012, and eventually SQL 
Server 2025.

## Distributed Enterprise Applications
The original Denali architecture was designed so that the business 
logic could be hosted in COM+ and execute on a separate machine.

This allowed the presentation layer to remain relatively lightweight 
while business processing and data access could be performed on more 
powerful application servers.

The physical separation was later be removed without fundamentally
changing the logical architecture. Maintaining the COM+ 
infrastructure had become increasingly difficult, while improvements 
in hardware made it practical to run the components on a single 
machine.

## Modernizing the Architecture
As the hardware and software environment changed, the physical
architecture of Denali was simplified while the logical architecture
was retained.

The original system was designed to support distributed business
logic through COM+. As maintaining COM+ became increasingly 
difficult and hardware became significantly more capable, the need 
for physical separation decreased.

Rather than redesigning the entire application, the physical 
deployment was simplified while preserving the existing 
architectural boundaries.

## Replacing the Presentation Layer
One of the original goals of the Denali architecture was to allow the
presentation layer to be replaced without rewriting the underlying
business logic.

This goal has been demonstrated in practice.

A newer web-based user interface is being developed while continuing 
to use the existing business logic and lower-level components.

This demonstrates that the presentation layer was sufficiently
decoupled from the underlying business logic to allow a fundamentally
different user interface technology to be introduced without 
requiring the business rules to be rewritten.

## Supporting Multiple Data Sources

Another example of the evolution of the CMS software architecture was 
the Cougar Dtails business intelligence tool.

Cougar Dtails was written in C# using WPF and was designed to work 
with multiple generations of CMS accounting software. It could 
retrieve data from both the dBase files used by the older accounting 
software and the SQL Server database used by Denali.

The application used a repository-based design to isolate differences
between the underlying data sources. The repository implementation 
could be changed depending on which accounting system was being 
accessed, while the higher-level application code remained largely 
the same.

The repositories also performed the necessary translations between 
the field names and data structures used by the different accounting 
systems and the objects used by the application.

This provided a practical example of separating the application from 
the details of the underlying data source.

### Evolution of Data Access

The development of Cougar Dtails also demonstrated the evolution of data
access techniques within CMS.

In the older Denali code, database queries were frequently constructed as
dynamic SQL statements stored in strings and then sent directly to
SQL Server.

Cougar Dtails made extensive use of LINQ. This allowed queries to be
expressed using C# and provided a more strongly typed approach to working
with application data.

The difference was significant:

```text
Denali:

Business Logic
      |
      v
Build SQL String
      |
      v
SQL Server


Cougar Dtails:

Application
      |
      v
LINQ Query
      |
      v
Repository
      |
      +------------+------------+
      |                         |
      v                         v
    dBase                   SQL Server

```
The repository abstraction allowed the application to work with 
different data sources while hiding many of the implementation 
details from the higher-level code.

### Lessons From Supporting Multiple Generations of Software
Supporting both dBase and SQL Server demonstrated the value of 
separating application logic from data access.

The two databases represented very different technologies and data 
models, but the application could present a consistent model to the 
rest of the system.

This experience also demonstrated that data abstraction is not simply
about hiding connection strings or database APIs. Different data 
sources may require translation between their schemas, field names, 
data types, and representations.

A successful abstraction must account for those differences without
allowing them to leak into the application logic.

## Lessons Learned

### Technology Changes, Principles Remain
Programming languages and frameworks change, but many fundamental 
software engineering principles remain the same.

The custom indexing system developed for a floppy-based DOS 
application and modern database indexes solve related problems: 
efficiently locating data without examining every record.

### Architecture Must Consider Its Environment
The architecture that made sense for an application in the early 
2000s may not be appropriate decades later.

Hardware costs, network performance, deployment practices, and 
maintenance costs all influence architectural decisions.

### Good Architecture Enables Evolution
The Denali architecture allowed the presentation layer to evolve 
from desktop applications toward web applications without requiring 
the business logic to be rewritten.

### Separation Requires More Than Layers
Simply putting code into different projects or assemblies does not
guarantee that the components are independently replaceable.

True separation requires well-defined contracts, controlled 
dependencies, and limited knowledge of implementation details.

This became apparent in Denali's data access architecture. Although 
the data layer was logically separated, the business logic became 
tightly coupled to SQL Server and the existing database schema, 
making the data layer much more difficult to replace than the 
presentation layer.

## Technology Evolution
My experience with enterprise software has followed several major
technology transitions:

| Era                          | Technology                                     |
| ---------------------------- | ---------------------------------------------- |
| Early 1980s                  | DOS, QuickBasic, random-access files           |
| Later DOS applications       | Visual Basic 3, dBase                          |
| Early 2000s                  | MFC C++, VB.NET, SQL Server 2000               |
| Enterprise applications      | COM+, distributed N-Tier architecture          |
| Desktop modernization        | C#, WPF, VB.NET                                |
| Web/API development          | ASP.NET, ASP.NET Core, REST APIs               |
| Modern .NET                  | .NET Core, .NET 5+, .NET 8/9/10                |
| Testing                      | xUnit, Microsoft Fakes, code coverage          |
| Modern development practices | Dependency Injection, automated testing, CI/CD |

## Interview Questions
**How has enterprise software changed during your career?**

**Tell me about a legacy system you have worked on.**

**How would you modernize a legacy application without rewriting 
it?**

**Describe a time when an architectural decision had to change 
because technology or hardware changed.**

**Tell me about a system where you successfully replaced one layer 
without rewriting the entire application.**

**Tell me about an architectural goal that was not completely 
successful. What did you learn from it?**

**How did you optimize software when hardware resources were 
limited?**