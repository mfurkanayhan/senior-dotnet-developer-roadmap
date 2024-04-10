
# Introduction to HTML for Beginners

Welcome to your first steps into the world of HTML! HTML (HyperText Markup Language) is the standard markup language used to create web pages. It describes the structure of web pages using markup. Elements are the building blocks of HTML pages, and through this guide, we'll explore some of the most commonly used elements in HTML.

# Basic Structure of an HTML Document

Every HTML document begins with a `<!DOCTYPE html>` declaration, defining it as an HTML5 document. Here is a simple structure of an HTML page:

```HTML
<!DOCTYPE html>
<html>
    <head>
        <!-- Metadata and links to CSS/JS files go here -->
    </head>
    <body>
        <!-- Content of your webpage goes here -->
    </body>
</html>
```

# Common HTML Elements

## Headings

Headings are defined with the `<h1>` to `<h6>` tags, where `<h1>` defines the most important heading, and `<h6>` defines the least important.

Example:
```HTML
<h1>This is a Heading 1</h1>
<h2>This is a Heading 2</h2>
...
<h6>This is a Heading 6</h6>
```

# Paragraphs

The <p> tag defines a paragraph.

Example:

```HTML
<p>This is a paragraph.</p>
```

# Links

The `<a>` tag defines a hyperlink, which is used to link from one page to another.

Example:

```HTML
<a href="https://www.example.com">This is a link</a>
```

# Images

The `<img>` tag is used to embed an image in an HTML page. The `src` attribute specifies the path to the image.

Example:

```HTML
<img src="image.jpg" alt="Descriptive text">
```

# Lists

There are two types of lists in HTML: unordered (`<ul>`) and ordered (`<ol>`). Each list item is marked with the `<li>` tag.

Example:

```HTML
<ul>
    <li>List item 1</li>
    <li>List item 2</li>
</ul>
```

# Tables

The `<table>` tag defines a table. It is divided into table rows (`<tr>`), headers (`<th>`), and data cells (`<td>`).

Example:

```HTML
<table>
    <tr>
        <th>Header 1</th>
        <th>Header 2</th>
    </tr>
    <tr>
        <td>Data 1</td>
        <td>Data 2</td>
    </tr>
</table>
```

# Input Fields

The `<input>` tag specifies an input field where the user can enter data.

Example:

```HTML
<input type="text" name="username">
```

# Comments in HTML
Comments in HTML start with `<!--` and end with `-->`. They are not displayed in the browser but can help document your HTML.

Example:

```HTML
<!-- This is a comment -->
```

# Practice HTML Files
- **First HTML File:** Demonstrates the basic structure and introduces various headings and the input field.

- **Second HTML File:** Contains a simple "Hello, World!" example with headings.
- **Most Popular Elements:** Showcases various popular HTML elements like paragraphs, links, images, lists, and tables.
Dive into these examples, experiment by changing values, and see how the browser interprets your HTML. Happy coding!
- #### [Portfolio](https://github.com/mfurkanayhan/senior-dotnet-developer-roadmap/tree/main/03.HTML/Portfolio) - This bonus project is a multi-page HTML website showcasing a portfolio with home, about, skills, and contact sections, interconnected via a consistent navigation bar.

I hope this has been useful for you..