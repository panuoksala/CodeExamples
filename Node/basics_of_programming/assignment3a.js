// Assignment 3
function toSnakeCase(word, wordSecond) {
    return word.replaceAll(" ", "_") + wordSecond.replaceAll(" ", "_");
}

console.log(toSnakeCase("This is test string", "And this is also"));
