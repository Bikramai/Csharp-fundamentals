# C# Fundamentals
# Section: 1 - Getting Started
## C# vs .NET
C# is a programming language, while .NET is a framework. It consists of a run-time environment (CLR) and a class library that we use for building applications.

## CLR
When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it. For this to happen, we need CLR. When we run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. This process is called Just-in-time Compilation (JIT).

Architecture of .NET Applications
In terms of architecture, an application written with C# consists of building blocks called classes. A class is a container for data (attributes) and methods (functions). Attributes represent the state of the application. Methods include code. They have logic. That's where we implement our algorithms and write code.

A namespace is a container for related classes. So as your application grows in size, you may want to group the related classes into various namespaces for better maintainability.

As the number of classes and namespaces even grow further, you may want to physically separate related namespaces into separate assemblies. An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. An EXE file represents a program that can be executed. A DLL is a file that includes code that can be re-used across different programs.

# Section: 2 - Primitive Types and Expressions
- Variables and Constants
- Overflowing
- Scope
- Demo: Variables and constants
- Type Conversion
- Demo: Type Conversion
- Operators
- What are Logical Operators?
- Demo: Operators
- Comments
  
# Section: 3 - Non-Primitive Types
- Introduction
- Classes
- Structs
- Arrays
- Strings
- Enums
- Reference Types and Value Types

# Section: 4 - Control Flow
- Conditional Statements
- If/Else, Switch/Case
- Iteration Statements
- Demo: for Loops, Foreach loops, While loops
- Random Class

# Section: 5 - Arrays and Lists
- Arrays
- Demo: Arrays
- Lists
- Demo: Lists

#Section: 6 - Working with Dates
- DateTime
- TimeSpan

# Section: 7 - Working with Text
- String
- Demo: Strings
- Live Coding: Summarizing Text
- StringBuilder
- Procedural Programming

# Section: 8 - Working with Files
- Introduction to System.IO
- File and File Info
- Directory and Directory Info
- Path

# Section: 9 - Dubugging Applications
- Debugging Tools in Visual Studio
- Removing Side Effects
- Defensive Programming
- Call Stack Window
- Locals and Autos Windows
  
