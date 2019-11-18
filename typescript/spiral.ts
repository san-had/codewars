export function create_spiral(n: number) {    
 
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
        let counter = length;
        while (counter > 0) {
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            colIndex++;
            counter--;
        }
        colIndex--;
    }

    function MoveDown() {
        let counter = length - 1 - round;
        while(counter > 0) {
            rowIndex++;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }

    function MoveLeft() {
        let counter = length - 1 - round;
        while(counter > 0) {
            colIndex--;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }

    function MoveUp() {
        let counter = length - 2 - round;
        while(counter > 0) {
            rowIndex--;
            startValue++;
            spiralData[rowIndex][colIndex] = startValue;
            counter--;
        }
    }

    function MoveRight() {
        let counter = length - 2 - round;
        while(counter > 0) {
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