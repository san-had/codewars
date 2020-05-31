function solve(n) {
    var rest = n;
    var number_of_notes = 0;
    var notes = [500,200,100,50,20,10];
    for (var i = 0; i < notes.length; i++) {
        console.log(i + ": " + notes[i]);
        while (rest - notes[i] >= 0) {
            rest -= notes[i];
            number_of_notes += 1;
            console.log("-" + notes[i]);
            console.log(rest);
            console.log(number_of_notes);            
        }    
    }
    if (rest === 0) {
        return number_of_notes;
    }
    else {
        return -1;
    }
}

console.log(solve(42));