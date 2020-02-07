import { computeRanks } from "./sportsLeague";

const numberOfTeams: number = 6;
const expectedResult: string = "4,4,6,3,1,2";
const games: number[][] = [[0, 5, 2, 2],
                        [1, 4, 0, 2],
                        [2, 3, 1, 2],
                        [1, 5, 2, 2],
                        [2, 0, 1, 1],
                        [3, 4, 1, 1],
                        [2, 5, 0, 2],
                        [3, 1, 1, 1],
                        [4, 0, 2, 0]];

let ranks = computeRanks(numberOfTeams, games);

displayRanks(ranks);

function displayRanks(ranks:number[]) {
    for (let i = 0; i < ranks.length; i++) {
        console.log("Team" + i.toString() + " has rank: " + ranks[i].toString());        
    }
}