var cities = ["Barcelona", "Rome", "Helsinki", "London", "Paris"];
// Print only name, could be by just calling console log if we want more details
cities.forEach(function(value) { console.log(value)});

// Print shortest city name
cities.sort((a, b) => a.length - b.length);
// Print empty line for nicer ouput...
console.log('');
console.log(cities[0]);

// Append index in front of every city and print out
console.log('');
var newCities = cities.map(appendOne);
newCities.forEach(function(value) { console.log(value)});

function appendOne(city, index) {
    return index + city;
}