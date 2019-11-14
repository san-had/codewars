"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function peekHeight(mountain) {
    var pattern = " ";
    var nextPattern;
    var count;
    var peakHeight = 0;
    var index = 0;
    do {
        if (index != 0) {
            pattern = index.toString();
        }
        nextPattern = (index + 1).toString();
        count = putChar(mountain, pattern, nextPattern);
        if (count != 0) {
            index++;
        }
    } while (count != 0);
    peakHeight = index;
    displayMountain(mountain);
    return peakHeight;
}
exports.peekHeight = peekHeight;
function putChar(mountain, boundaryChar, newChar) {
    var rowMax = mountain.length;
    var count = 0;
    for (var i = 0; i < rowMax; i++) {
        var columnMax = mountain[i].length;
        for (var j = 0; j < columnMax; j++) {
            if (mountain[i][j] == '^') {
                if (i == 0 || j == 0 || i == rowMax - 1 || j == columnMax - 1) {
                    mountain[i][j] = newChar;
                    count++;
                    continue;
                }
                var newCharNeeded = mountain[i - 1][j] === boundaryChar || mountain[i][j - 1] === boundaryChar ||
                    mountain[i + 1][j] === boundaryChar || mountain[i][j + 1] === boundaryChar;
                if (newCharNeeded) {
                    mountain[i][j] = newChar;
                    count++;
                }
            }
        }
    }
    return count;
}
function displayMountain(mountain) {
    mountain.forEach(function (row) {
        console.log(row.join(''));
    });
}
//# sourceMappingURL=peekHeight.js.map