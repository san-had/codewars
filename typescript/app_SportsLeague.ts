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

const numberOfTeams2: number = 6;
const expectedResult2: string = "2,3,4,1,5,6";
const games2: number[][] = 
    [[0, 5, 2, 0],
     [1, 4, 2, 2],
     [2, 3, 1, 3],
     [1, 5, 0, 0],
     [2, 0, 2, 1],
     [3, 4, 3, 1]];
     
     const numberOfTeams3: number = 4;
     const expectedResult3: string = "3,1,1,3";
     const games3: number[][] = 
     [[0, 3, 1, 1],
     [1, 2, 2, 2],
     [1, 3, 2, 0],
     [2, 0, 2, 0]];  
          
          const numberOfTeams4: number = 10;
          const expectedResult4: string = "1,1,1,1,1,1,1,1,1,1";
          const games4: number[][] = 
          [];  
               
               const numberOfTeams5: number = 8;
               const expectedResult5: string = "1,2,2,2,2,2,2,8";
               const games5: number[][] = 
               [[0, 7, 2, 0]];                

let ranks = computeRanks(numberOfTeams5, games5);

displayRanks(ranks);

console.log(expectedResult5);


function displayRanks(ranks:number[]) {
    for (let i = 0; i < ranks.length; i++) {
        console.log("Team" + i.toString() + " has rank: " + ranks[i].toString());        
    }
}