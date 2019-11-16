import { create_spiral } from "./spiral";

let N: number = 3;

let spiralData = create_spiral(3);

displaySpiral(spiralData);

function displaySpiral(spiralData: number[][]) {
    let dimension = spiralData[0].length;

    for (let i = 0; i < dimension; i++) {
        let row = "";
        for (let j = 0; j < dimension; j++) {
            row = row + " " + spiralData[i][j]
        }
        console.log(row);        
    }

}