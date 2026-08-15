# LINQ Guide

This guide provides an overview of Language Integrated Query (LINQ) 
in .NET, including its features, benefits, and common use cases. 
LINQ is a powerful feature that allows developers to write queries 
directly in C# or VB.NET, enabling seamless data manipulation and 
retrieval from various data sources.

## Overview
- [What problem LINQ solves](./LINQ/What%20problem%20LINQ%20solves.md)
- [LINQ providers](./LINQ/LINQ%20providers.md)
- [Deferred execution](./LINQ/Deferred%20execution.md)
- [Query composition](./LINQ/Query%20composition.md)

## LINQ Syntax
- [Query syntax](./LINQ/Query%20syntax.md)
- [Method syntax](./LINQ/Method%20syntax.md)
- [Lambda expressions](./LINQ/Lambda%20expressions.md)

## Core Operations

### Filtering
- [Where](./LINQ/Where.md)

### Projection
- [Select](./LINQ/Select.md)
- [SelectMany](./LINQ/SelectMany.md)

### Ordering
- [OrderBy](./LINQ/OrderBy.md)
- [ThenBy](./LINQ/ThenBy.md)

### Grouping
- [GroupBy](./LINQ/GroupBy.md)

### Aggregation
- [Count](./LINQ/Count.md)
- [Sum](./LINQ/Sum.md)
- [Average](./LINQ/Average.md)
- [Min](./LINQ/Min.md)
- [Max](./LINQ/Max.md)

### Joining
- [Join](./LINQ/Join.md)
- [GroupJoin](./LINQ/GroupJoin.md)

### Set Operations
- [Distinct](./LINQ/Distinct.md)
- [Union](./LINQ/Union.md)
- [Intersect](./LINQ/Intersect.md)
- [Except](./LINQ/Except.md)

## Execution

- [IEnumerable&lt;T&gt; vs IQueryable&lt;T&gt;](./LINQ/IEnumerable%20vs%20IQueryable.md)
- [Deferred vs immediate execution](./LINQ/Deferred%20vs%20immediate%20execution.md)
- [ToList(), ToArray(), First(), Single()](./LINQ/ToList%20vs%20ToArray.md)

## Performance Considerations

- [Multiple enumeration](./LINQ/Multiple%20enumeration.md)
- [Large collections](./LINQ/Large%20collections.md)
- [Database query translation](./LINQ/Database%20query%20translation.md)
- [N+1 query problems](./LINQ/N+1%20query%20problems.md)

## Interview Questions

- [What is deferred execution?](./LINQ/What%20is%20deferred%20execution.md)
- [What is the difference between IEnumerable and IQueryable?](./LINQ/What%20is%20the%20difference%20between%20IEnumerable%20and%20IQueryable.md)
- [When does a LINQ query actually execute?](./LINQ/When%20does%20a%20LINQ%20query%20actually%20execute.md)
- [How does Entity Framework translate LINQ?](./LINQ/How%20does%20Entity%20Framework%20translate%20LINQ.md)