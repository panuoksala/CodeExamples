// Find best buy and sell from given array of numbers
function findBestTrades(rates) {
  const clone = [].concat(rates)

  clone.sort((a,b) => a - b);
  var bestBuy = clone[0];
  var bestSell = clone[rates.length -1];
  return {BestBuy: bestBuy, IndexBuy: rates.indexOf(bestBuy), BestSell: bestSell, IndexSell: rates.indexOf(bestSell)};
}

// Build array of random numbers and return it.
function getArrayOfRandomNumbers(amount) {
const randomNumbers = [];
for(var i=0;i<amount;i++)
{
  // Append random number into array
  varandomNumbers.push(getRandomInt(301));
}
return randomNumbers;
}

// JavaScript random returns float, so we will use floor to get the integer version.
function getRandomInt(max) {
  return Math.floor(Math.random() * max);
}

// Get 5 random numbers
var numbers = getArrayOfRandomNumbers(5);
console.log(numbers);
// Get best trade for these random numbers
var result = findBestTrades(numbers);
console.log(result);
