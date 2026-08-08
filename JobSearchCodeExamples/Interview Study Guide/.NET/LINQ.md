# LINQ Guide

This guide provides an overview of Language Integrated Query (LINQ) 
in .NET, including its features, benefits, and common use cases. 
LINQ is a powerful feature that allows developers to write queries 
directly in C# or VB.NET, enabling seamless data manipulation and 
retrieval from various data sources.

## Overview
- What problem LINQ solves
- LINQ providers
- Deferred execution
- Query composition

## LINQ Syntax
- Query syntax
- Method syntax
- Lambda expressions

## Core Operations

### Filtering
- Where

### Projection
- Select
- SelectMany

### Ordering
- OrderBy
- ThenBy

### Grouping
- GroupBy

### Aggregation
- Count
- Sum
- Average
- Min
- Max

### Joining
- Join
- GroupJoin

### Set Operations
- Distinct
- Union
- Intersect
- Except

## Execution

- IEnumerable<T> vs IQueryable<T>
- Deferred vs immediate execution
- ToList(), ToArray(), First(), Single()

## Performance Considerations

- Multiple enumeration
- Large collections
- Database query translation
- N+1 query problems

## Interview Questions

- What is deferred execution?
- What is the difference between IEnumerable and IQueryable?
- When does a LINQ query actually execute?
- How does Entity Framework translate LINQ?