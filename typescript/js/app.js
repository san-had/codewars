"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var spiral_1 = require("./spiral");
var N = -1;
var spiralData = spiral_1.create_spiral(N);
displaySpiral(spiralData);
function displaySpiral(spiralData) {
    var dimension = spiralData.length;
    for (var i = 0; i < dimension; i++) {
        var row = "";
        for (var j = 0; j < dimension; j++) {
            row = row + " " + spiralData[i][j];
        }
        console.log(row);
    }
}
//# sourceMappingURL=app.js.map