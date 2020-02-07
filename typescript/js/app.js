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
var ranks = sportsLeague_1.computeRanks(numberOfTeams, games);
displayRanks(ranks);
function displayRanks(ranks) {
    for (var i = 0; i < ranks.length; i++) {
        console.log("Team" + i.toString() + " has rank: " + ranks[i].toString());
    }
}
//# sourceMappingURL=app.js.map