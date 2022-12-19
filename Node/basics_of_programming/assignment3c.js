// PHASE 1 START -->

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

function filterOdd(arr) {
  const filteredArr = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 !== 0) {
      filteredArr.push(arr[i]);
    }
  }
  return filteredArr;
}
console.log(filterOdd(arr));

// <-- End of phase 1
// PHASE 2 START -->

function filterEven(arr) {
  const filteredArr = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 === 0) {
      filteredArr.push(arr[i]);
    }
  }
  return filteredArr;
}
console.log(filterEven(arr));

// <-- End of phase 2
// PHASE 3 START -->

function filterFunction(arr, callback) {
}

// <--End of phase 3
// PHASE 4 START -->

function isOdd(x) {
    return x % 2 != 0;
  }
  
  function isEven(x) {
    return x % 2 === 0;
  }
  
// <-- End of phase 4
// PHASE 5 START -->

function filterFunction2(arr, callback) {
    const filteredArr = [];
    for (let i = 0; i < arr.length; i++) {
        if(callback(arr[i]) === true) {
             filteredArr.push(arr[i]);
        }
    }
    return filteredArr;
}

console.log(filterFunction2(arr, isEven));
// <-- End of phase 5