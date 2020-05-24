function asteriscIt(n) {
    var length = n.toString().length;
    var tmpArray = [];
    var previous = 0;
    for (var i = 0; i < length; i++) {
      if (i === 0 ) {
        previous = n.toString()[i];
      }
      if (i > 0) {
        current = parseInt(n.toString()[i]);
        if (!(previous % 2) && !(current % 2)) {
          tmpArray.push("*");
        }
        previous = current;
      }
      tmpArray.push(parseInt(n.toString()[i]));
     }
    var result = tmpArray.join('');
  return result;
};

console.log(asteriscIt([1, 4, 64, 68, 67, 23, 1]));

//asteriscIt(5312708)