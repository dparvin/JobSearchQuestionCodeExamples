# Assemblies Guide
An assembly is a compiled unit of .NET code and metadata. Assemblies
are typically represented by `.dll` or `.exe` files and contain the
information required by the .NET runtime to load and execute the 
code.

Assemblies are important to .NET because they provide a boundary for
deployment, type definitions, metadata, dependencies, and versioning.

## Topics

- [What Is an Assembly?](#what-is-an-assembly)
- [Assembly Contents](#assembly-contents)
- [Assembly Manifest](#assembly-manifest)
- [Metadata](#metadata)
- [Assembly Versioning](#assembly-versioning)
- [Strong-Named Assemblies](#strong-named-assemblies)
- [Assembly Loading](#assembly-loading)
- [Private and Shared Assemblies](#private-and-shared-assemblies)
- [Global Assembly Cache](#global-assembly-cache)
- [Assemblies in Modern .NET](#assemblies-in-modern-net)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## What Is an Assembly

An assembly is a compiled unit of .NET code.

For example, a C# project might produce:

```text
MyApplication.dll
```
or:
```text
MyApplication.exe
```

An assembly can contain:

- Intermediate Language (CIL)
- Type definitions
- Metadata
- An assembly manifest
- Resources
- References to other assemblies

An assembly provides a boundary around the compiled code and the
information required to use that code.

## Assembly Contents
The major components of an assembly include:

### CIL

The compiler converts .NET source code into Common Intermediate 
Language (CIL). The CIL is stored in the assembly and is later 
compiled to native machine code by the runtime's JIT compiler.

### Metadata
Metadata describes the types and members contained within the 
assembly.

For example, metadata can describe:

- Classes
- Structures
- Interfaces
- Methods
- Properties
- Fields
- Attributes
- Parameter types

### Manifest
The assembly manifest contains information about the assembly itself,
including:

- Assembly name
- Assembly version
- Culture
- Referenced assemblies
- Other assembly identity information

### Resources
Assemblies can contain embedded resources such as:

- Images
- Strings
- Other application resources

## Assembly Versioning
Assemblies have version information that can be used to identify
different versions of an assembly.

The assembly version is part of the assembly identity.

.NET projects may also contain other version information, such as
file version and informational version. These values serve different
purposes and should not be treated as interchangeable.

## Strong-Named Assemblies
A strong-named assembly has a strong name that provides an identity
based on the assembly name, version, culture, and public key 
information.

Strong naming was particularly important for .NET Framework 
applications and assemblies deployed to the Global Assembly Cache.

Strong naming should not be confused with general application 
security or code signing.

## Assembly Loading
The .NET runtime loads assemblies as they are needed by an 
application.

Modern .NET provides `AssemblyLoadContext` to control how assemblies
are loaded and isolated within an application.

Assembly loading can become important when applications need to:

- Load plugins
- Load multiple versions of an assembly
- Isolate dependencies
- Dynamically load assemblies

## Private and Shared Assemblies
### Private Assemblies
A private assembly is deployed with an application and is normally 
used only by that application.

This is the typical deployment model for application dependencies.

### Shared Assemblies
In .NET Framework, assemblies could be installed into the Global
Assembly Cache (GAC) so that multiple applications could share them.

This model is much less important in modern .NET, where 
application-local deployment is generally preferred.

### Global Assembly Cache
The Global Assembly Cache (GAC) is a .NET Framework mechanism for 
storing assemblies that are shared by multiple applications.

The GAC helped solve dependency and versioning problems in 
applications that shared common assemblies.

Modern .NET does not use the GAC as its primary dependency deployment
mechanism.

## Assemblies in Modern .NET
Modern .NET applications commonly use application-local assemblies
managed through the project system and NuGet.

For example:
```text
MyApplication/
    MyApplication.dll
    MyApplication.deps.json
    MyApplication.runtimeconfig.json
    SomeLibrary.dll
```

The `.deps.json` file describes dependencies required by the 
application, while the runtime configuration specifies information 
about the runtime needed by the application.

## Common Interview Questions
- What is an assembly in .NET?
- What is contained in an assembly?
- What is the difference between an assembly and a namespace?
- What is the purpose of the assembly manifest?
- What is the difference between an assembly version and a file 
  version?
- What is a strong-named assembly?
- What is the Global Assembly Cache?
- How does assembly loading work in .NET?
- What is AssemblyLoadContext?
- How are assemblies deployed differently in .NET Framework and 
  modern .NET?

## My Experience
My experience with .NET includes working with assemblies across both
.NET Framework and modern .NET applications.

Assemblies have been an important part of managing the large
multi-project applications I have worked with, including applications
containing components written in multiple .NET languages.

A project is a **development/build concept**. An assembly is a
**compiled deployment/runtime concept**.

A .NET solution can contain multiple projects, and those projects
can produce one or more assemblies. The project configuration
determines what is compiled and how the resulting assembly and its
dependencies are produced.

This distinction is important when working with large multi-project
applications because the project structure used during development
does not necessarily represent the same boundaries used by the
runtime.