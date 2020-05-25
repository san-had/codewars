function asteriscIt(n) {
    var numbers = Array.isArray(n) ? n.join('') : n.toString();
    var length = numbers.toString().length;
    var asteriscStr = "";
    var previous = 0;
    for (var i = 0; i < length; i++) {
      if (i === 0 ) {
        previous = numbers.toString()[i];
      }
      if (i > 0) {
        current = parseInt(numbers.toString()[i]);
        if (!(previous % 2) && !(current % 2)) {
          asteriscStr += "*";
        }
        previous = current;
      }
      asteriscStr += numbers.toString()[i];
     }
  return asteriscStr;
};

console.log(asteriscIt([1, 4, 64, 68, 67, 23, 1]));

console.log(asteriscIt(5312708));

//asteriscIt(5312708)