"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function create_spiral(n) {
    if (n < 1 || isNaN(n)) {
        n = 0;
    }
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
    do {
        if (IsEnd()) {
            break;
        }
        MoveDown();
        MoveLeft();
        if (IsEnd()) {
            break;
        }
        MoveUp();
        MoveRight();
        round += 2;
    } while (true);
    return spiralData;
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
    function MoveDown() {
        var counter = length - 1 - round;
        while (counter > 0) {
            rowIndex++;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }
    function MoveLeft() {
        var counter = length - 1 - round;
        while (counter > 0) {
            colIndex--;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }
    function MoveUp() {
        var counter = length - 2 - round;
        while (counter > 0) {
            rowIndex--;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }
    function MoveRight() {
        var counter = length - 2 - round;
        while (counter > 0) {
            colIndex++;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }
    function IsEnd() {
        return startValue == lastValue;
    }
}
exports.create_spiral = create_spiral;
//# sourceMappingURL=spiral.js.map