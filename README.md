<div align="center">
    <h1 style="color: #00ffff"> Paragma </h1>
    <p>Paragma is an intuitive editor and compiler designed for Tiny Language, a virtual programming language developed in C#. It employs fundamental principles of compiler theory, featuring an impressive graphical user interface that enhances the user experience.</p>
</div>

## Table of Contents
1. [What is Tiny Language](#what-is-tiny-language)
2. [Editor GUI](#editor-gui)
3. [Compiler](#compiler)
4. [Contributing](#contributing)

## What is Tiny Language

**Tiny Language** is a hypothetical programming language designed to illustrate fundamental concepts of compiler theory and programming language design. Here’s a brief overview of its features and characteristics:

### Overview of Tiny Language

1. **Purpose:** 
   - Tiny Language serves as an educational tool for understanding basic programming constructs and the underlying principles of compiler construction. It simplifies many complexities found in real-world programming languages to facilitate learning.

2. **Syntax and Structure:**
   - **Data Types:** Supports basic data types such as integers, floats, and strings.
   - **Variables:** Allows declaration and initialization of variables.
   - **Operators:** Includes arithmetic, relational, and logical operators for performing operations.
   - **Control Flow:** Utilizes conditional statements (`if`, `elseif`, `else`) and loops (`repeat ... until`) for controlling the flow of execution based on conditions.
   - **Input/Output:** Provides commands for reading user input and writing output to the console.

3. **Lexical Elements:**
   - **Tokens:** The language uses tokens to represent its syntactic elements, such as keywords (e.g., `int`, `if`), identifiers (variable names), literals (numbers, strings), and operators.
   - **Reserved Words:** A predefined set of keywords that have special meanings in the language.

4. **Comments:**
   - Supports comments (e.g., `/* This is a comment */`) to allow developers to annotate their code without affecting execution.

5. **Simplicity:**
   - The language is intentionally minimalistic, focusing on essential constructs to avoid overwhelming beginners while providing enough complexity to illustrate core programming concepts.

#

## Editor GUI

![Editor GUI](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/basic.png)
<br/>

The **Paragma Editor** features a user-friendly graphical interface designed for coding in Tiny Language. It provides essential tools and functionalities that enhance the coding experience, including:

- **Syntax Highlighting**: Distinguishes keywords, identifiers, and operators with different colors for improved readability.
- **Code Formatting**: Automatically formats your code, making it easy to read and maintain.
- **User-Friendly Layout**: Simple navigation and an intuitive design make it accessible for both beginners and experienced users.
- **File Management**: Supports saving and opening Tiny Language files seamlessly.

![Editor Functionality](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/bar.png)

## Compiler

The **Paragma Compiler** is a vital component of the Paragma project, enabling the execution of scripts written in Tiny Language. It translates high-level Tiny Language code into machine-readable format, facilitating program execution. Key functionalities of the compiler include:

- **Lexical Analysis**: Breaks down the source code into tokens, identifying keywords, operators, constants, identifiers, and punctuation.

- **Syntax Analysis**: Checks the structure of the code against the grammatical rules of Tiny Language, constructing a syntax tree and identifying syntactical errors.

- **Semantic Analysis**: Validates the meaning of statements, ensuring type consistency and checking that variables are declared before use.

- **Intermediate Code Generation**: Generates intermediate code that serves as a bridge between high-level Tiny Language and machine code.

- **Code Generation**: Translates the intermediate code into machine code that can be executed by the runtime environment.

- **Error Reporting**: Provides detailed error messages and warnings for issues detected during the compilation process, facilitating quick debugging.

- **User Feedback**: Offers meaningful feedback to users, including informative messages about the compilation status and insights on potential issues.

#

## Contributing

Contributions are welcome! If you have suggestions, bug reports, or improvements, please create an issue or submit a pull request.
