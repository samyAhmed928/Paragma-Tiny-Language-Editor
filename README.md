<div align="center">
      <h1 style="color: #00ffff">Paragma</h1>

  <p>
    <strong>A Python class for stemming Arabic words</strong>
  </p>
  <p>
Paragma is an intuitive editor and compiler designed for Tiny Language, a virtual programming language developed in C#. It employs fundamental principles of compiler theory, featuring an impressive graphical user interface that enhances the user experience.  </p>

</div>

## Table of Contents
- What is Tiny Language?
- [Example](#example)
- [Stemming Rules](#stemming-rules)
- [Contributing](#contributing)


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
   - Supports  comments (e.g., `/* This is a comment */`) to allow developers to annotate their code without affecting execution.

5. **Simplicity:**
   - The language is intentionally minimalistic, focusing on essential constructs to avoid overwhelming beginners while providing enough complexity to illustrate core programming concepts.

## Example
```python
from fcis_steamer import FcisStemmer

def main():
    s = fcis_stemmer()
    sentence = input("Enter a sentence: ")

    stemmed_sentence = ""
    for word in sentence.split():
        stemmed_word = s.stem(word)
        stemmed_sentence += stemmed_word + " "

    print("Original sentence: " + sentence)
    print("Stemmed sentence: " + stemmed_sentence.strip())

if __name__ == "__main__":
    main()
```

## Stemming Rules

The `FcisStemmer` class implements the following stemming rules:

- Removal of common "alif lam" prefixes.
- Replacement of specific words with "الله".
- Removal of certain suffixes like plurals and definite articles.
- Modifying verb forms to their root or base form.
- Conversion of future tense to past tense.
- And more.


## Contributing

Contributions are welcome! If you have suggestions, bug reports, or improvements, please create an issue or submit a pull request.
