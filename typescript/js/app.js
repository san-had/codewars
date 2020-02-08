"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var sportsLeague_1 = require("./sportsLeague");
var numberOfTeams = 6;
var expectedResult = "4,4,6,3,1,2";
var games = [[0, 5, 2, 2],
    [1, 4, 0, 2],
    [2, 3, 1, 2],
    [1, 5, 2, 2],
    [2, 0, 1, 1],
    [3, 4, 1, 1],
    [2, 5, 0, 2],
    [3, 1, 1, 1],
    [4, 0, 2, 0]];
var numberOfTeams2 = 6;
var expectedResult2 = "2,3,4,1,5,6";
var games2 = [[0, 5, 2, 0],
    [1, 4, 2, 2],
    [2, 3, 1, 3],
    [1, 5, 0, 0],
    [2, 0, 2, 1],
    [3, 4, 3, 1]];
var numberOfTeams3 = 4;
var expectedResult3 = "3,1,1,3";
var games3 = [[0, 3, 1, 1],
    [1, 2, 2, 2],
    [1, 3, 2, 0],
    [2, 0, 2, 0]];
var numberOfTeams4 = 10;
var expectedResult4 = "1,1,1,1,1,1,1,1,1,1";
var games4 = [];
var numberOfTeams5 = 8;
var expectedResult5 = "1,2,2,2,2,2,2,8";
var games5 = [[0, 7, 2, 0]];
var ranks = sportsLeague_1.computeRanks(numberOfTeams5, games5);
displayRanks(ranks);
console.log(expectedResult5);
function displayRanks(ranks) {
    for (var i = 0; i < ranks.length; i++) {
        console.log("Team" + i.toString() + " has rank: " + ranks[i].toString());
    }
}
//# sourceMappingURL=app.js.map