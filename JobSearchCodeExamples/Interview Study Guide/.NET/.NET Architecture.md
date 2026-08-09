# .NET Architecture Guide

This guide provides an overview of the architecture of .NET,
including the runtime, execution model, type system, assemblies,
and application architecture.

Understanding the architecture of .NET helps developers understand
how .NET applications are compiled, loaded, executed, and managed,
as well as how the different components of the platform work together.

## Topics
- [Common Language Runtime (CLR)](CLR.md)
- [Base Class Library (BCL)](Base%20Class%20Library.md)
- [Common Intermediate Language (CIL)](Common%20Intermediate%20Language.md)
- [Just-In-Time Compilation](Just-In-Time%20Compilation.md)
- [Assemblies](Assemblies.md)
- [Metadata](Metadata.md)
- [Common Type System (CTS)](Common%20Type%20System.md)
- [Common Language Specification (CLS)](Common%20Language%20Specification.md)
- [Garbage Collection](Garbage%20Collection.md)
- [Managed and Unmanaged Code](Managed%20and%20Unmanaged%20Code.md)
- [.NET Application Models](.NET%20Application%20Models.md)
- [.NET Framework vs. Modern .NET](.NET%20Framework%20vs%20Modern%20.NET.md)
- [.NET SDK and Runtime](.NET%20SDK%20and%20Runtime.md)
- [Application Deployment](Application%20Deployment.md)

## Execution Flow
The execution flow of a .NET application involves several stages, 
from writing code to running the application:

```
C# / VB.NET / F# Source Code
            |
            v
        Compiler
            |
            v
  Intermediate Language (CIL)
            |
            v
        Assembly
            |
            v
      .NET Runtime
            |
            v
       JIT Compiler
            |
            v
    Native Machine Code
```

The compiler converts source code into CIL rather than directly
into the native machine code of the target processor.

The resulting assembly contains CIL, metadata, and other information
required by the runtime.

When the application runs, the .NET runtime loads the assembly and
the JIT compiler converts CIL into native machine code for the
target processor.

This allows the same compiled assembly to run on different
supported platforms without requiring the source code to be
compiled directly for each processor architecture.

