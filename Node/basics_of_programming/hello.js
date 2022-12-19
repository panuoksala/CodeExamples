// Assignment 1
let dateobj = new Date();
console.log('Hello World ' + dateobj);

// Assignment 2
let string = "Test";
console.log(string);

let number = 10;
console.log(number);

let bool = true;
console.log(bool);

let obj = new Object({ TestProperty: "Test string inside property"});
console.log(obj["TestProperty"]);

dateobj = new Date(2022, 12, 15);
string = "TestTwo";
number = 15;
bool = false;
obj.TestProperty = "Hi!";

console.log(string + ' ' + number + ' ' + bool + ' ' + obj["TestProperty"]);

