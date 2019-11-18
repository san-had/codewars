import { create_spiral } from "./spiral";

let N: number = 10;

let spiralData = create_spiral(N);

displaySpiral(spiralData);

function displaySpiral(spiralData: number[][]) {
    let dimension = spiralData.length;

    for (let i = 0; i < dimension; i++) {
        let row = "";
        for (let j = 0; j < dimension; j++) {
            row = row + " " + spiralData[i][j]
        }
        console.log(row);        
    }

}