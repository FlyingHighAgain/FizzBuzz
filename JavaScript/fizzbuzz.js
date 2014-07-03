// fizzbuzz.js

for (i =0; i < 100; i++) {
  console.log(
    function(x) {
      if (x % 3 === 0 && x % 5 ===  0) {
        return "FizzBuss";
      } else if (x % 3 === 0) {
        return "Fizz";
      } else if (x % 5 === 0) {
        return "Buzz";
      } else {
        return x;
      }
  }(i));
}


