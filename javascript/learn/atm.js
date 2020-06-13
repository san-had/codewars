function solve(n) {
    if (n % 10 !== 0) {
        return -1;
    }

    var number_of_notes = 0;
    var notes = [500,200,100,50,20,10];
    for (var i = 0; i < notes.length; i += 1) {
        while (n - notes[i] >= 0) {
            n -= notes[i];
            number_of_notes += 1;
        }    
    }
    return number_of_notes;
}

console.log(solve(1250));