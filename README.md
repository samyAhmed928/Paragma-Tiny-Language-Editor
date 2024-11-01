<div align="center">
      <h1 style="color: #00ffff">Paragma</h1>

  <p>
    <strong>A Python class for stemming Arabic words</strong>
  </p>
  <p>
Paragma is an intuitive editor and compiler designed for Tiny Language, a virtual programming language developed in C#. It employs fundamental principles of compiler theory, featuring an impressive graphical user interface that enhances the user experience.  </p>

</div>

## Table of Contents
- [What is Tiny Language?](#WhatisTinyLanguage?)
- [Example](#example)
- [Stemming Rules](#stemming-rules)
- [Contributing](#contributing)


## WhatisTinyLanguage?
1. Ensure you have Python installed on your system.
2. Clone the repository or download the `fcis_steamer.py` file.

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
