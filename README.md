<div align="center">
    <h1 style="color: #00ffff">Paragma</h1>
    <p>Paragma is an intuitive editor and compiler designed for Tiny Language, a virtual programming language developed in C#. It employs fundamental principles of compiler theory, featuring an impressive graphical user interface that enhances the user experience.</p>
</div>

## Table of Contents
1. [Editor GUI](#editor-gui)
2. [What is Tiny Language](#what-is-tiny-language)
3. [Compiler](#compiler)
   - [Tokens](#tokens)
   - [Parse Tree](#parse-tree)
   - [Errors](#errors)
4. [Contributing](#contributing)

## Editor GUI

![Editor GUI](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/basic.png)
<br/>

The **Paragma Editor** features a user-friendly graphical interface designed for coding in Tiny Language. It provides essential tools and functionalities that enhance the coding experience, including:

- **Syntax Highlighting**: Distinguishes keywords, identifiers, and operators with different colors for improved readability.
- **Code Formatting**: Automatically formats your code, making it easy to read and maintain.
- **User-Friendly Layout**: Simple navigation and an intuitive design make it accessible for both beginners and experienced users.
- **File Management**: Supports saving and opening Tiny Language files seamlessly.



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

## Compiler

The **Paragma Compiler** is a vital component of the Paragma project, enabling the execution of scripts written in Tiny Language. It translates high-level Tiny Language code into machine-readable format, facilitating program execution. Key functionalities of the compiler include:
![Editor GUI](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/run.png)
<br/>
### Tokens

Tokens are the fundamental building blocks of Tiny Language, representing the smallest elements of the language. Here are the primary categories of tokens used in Tiny Language:
<br/>
![Editor GUI](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/tokens.png)
<br/>

1. **Keywords**: Reserved words that have special meanings. Examples include:
   - `int`
   - `if`
   - `else`
   - `repeat`
   - `until`

2. **Identifiers**: Names given to variables and functions that follow specific naming conventions (e.g., must start with a letter, can include letters, digits, and underscores).

3. **Literals**: Fixed values in the code. These can be:
   - **Integer Literals**: Numeric values without decimal points (e.g., `10`, `-3`).
   - **Float Literals**: Numeric values with decimal points (e.g., `3.14`, `-0.01`).
   - **String Literals**: Text enclosed in quotes (e.g., `"Hello, World!"`).

4. **Operators**: Symbols that represent computations or comparisons. Common operators include:
   - **Arithmetic Operators**: `+`, `-`, `*`, `/`
   - **Relational Operators**: `==`, `!=`, `<`, `>`, `<=`, `>=`
   - **Logical Operators**: `&&` (AND), `||` (OR)

5. **Punctuation**: Symbols used for various syntactical purposes, such as:
   - **Semicolons** (`;`): Denotes the end of a statement.
   - **Braces** (`{}`): Used for grouping statements.
   - **Parentheses** (`()`) : Used for grouping expressions and function calls.

### Parse Tree

The **Parse Tree** is a hierarchical representation of the syntactic structure of a source code written in Tiny Language. It is constructed during the syntax analysis phase of compilation and serves several important purposes:
<br/>
![Editor GUI](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/parsetree.png)
<br/>
1. **Visual Representation**: The parse tree visually depicts the relationships between different syntactic elements, illustrating how the source code is structured.
2. **Syntax Validation**: By constructing the parse tree, the compiler can validate that the code adheres to the grammatical rules of Tiny Language.
3. **Facilitate Code Generation**: The parse tree provides a foundation for generating intermediate code and eventually translating it into machine code. It breaks down complex expressions and statements into manageable components.
4. **Error Detection**: The parse tree can help identify errors in the code structure, aiding in debugging and improving code quality.

The Paragma project can provide visual feedback of the parse tree to help users understand how their code is interpreted by the compiler.

### Errors

Error handling is a crucial aspect of the Paragma Compiler. The compiler detects various types of errors during the compilation process, helping users identify and resolve issues in their code:

<br/>
![Errors GUI](https://github.com/samyAhmed928/Paragma-Tiny-Language-Editor/blob/master/ex-images/errors.png)
<br/>

1. **Lexical Errors**: Occur when the code contains invalid tokens or unrecognized characters.
2. **Syntax Errors**: Arise when the code structure does not conform to the grammar rules of Tiny Language. Common examples include missing semicolons or mismatched parentheses.
3. **Semantic Errors**: Occur when the code is syntactically correct but fails to make logical sense. For instance, using an undeclared variable or attempting to perform an operation on incompatible data types.


The compiler provides informative messages for each error type, assisting users in debugging their code efficiently.

## Contributing

Contributions are welcome! If you have suggestions, bug reports, or improvements, please create an issue or submit a pull request.
