export function create_spiral(n: number) {    
 /*    let spiralData: number[][] = 
    [
        [1, 2, 3],
        [8, 9, 4],
        [7, 6, 5]
    ]; */

    //let spiralData: number[][] = [];

    let spiralData = new Array(n);
    for (let i = 0; i < n; i++) {
        spiralData[i] = new Array(n);
    }

    if (n < 1) {
        return spiralData;
    }

    let rowIndex: number = 0;

    let colIndex: number = 0;

    let length: number = n;

    let startValue: number = 0;

    let lastValue: number = n * n;

    let round: number = 0;

    MoveRightFirst();

    console.log(startValue);
    

    function MoveRightFirst() {
        let counter = length;
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

function MoveRightFirst() {

}