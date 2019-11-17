"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function create_spiral(n) {
    /*    let spiralData: number[][] =
       [
           [1, 2, 3],
           [8, 9, 4],
           [7, 6, 5]
       ]; */
    //let spiralData: number[][] = [];
    var spiralData = new Array(n);
    for (var i = 0; i < n; i++) {
        spiralData[i] = new Array(n);
    }
    if (n < 1) {
        return spiralData;
    }
    var rowIndex = 0;
    var colIndex = 0;
    var length = n;
    var startValue = 0;
    var lastValue = n * n;
    var round = 0;
    MoveRightFirst();
    console.log(startValue);
    function MoveRightFirst() {
        var counter = length;
        while (counter > 0) {
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            colIndex++;
            counter--;
        }
        colIndex--;
    }
    return spiralData;
}
exports.create_spiral = create_spiral;
function MoveRightFirst() {
}
//# sourceMappingURL=spiral.js.map