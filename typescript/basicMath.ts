export function calculate(inputStr: string) {

    while(inputStr.indexOf("plus") > 0) {
        inputStr = inputStr.replace("plus", "+");
    }

    while(inputStr.indexOf("minus") > 0) {
        inputStr = inputStr.replace("minus", "-");
    }

    let total: number = getFirstItem(inputStr);

    do {

    let operation: string = getOperation(inputStr);

    let item: number = parseInt(inputStr.substr(0,index));

    inputStr = inputStr.substr(index + 1);

    if (operation == "+") {
        total += item;
    } else {
        total -= item;
    }
    
    } while ()



    let result: string = total.toString();

    return result;
}

function getFirstItem(inputStr:string) {

    let indexPlus = inputStr.indexOf("+");
    let indexMinus = inputStr.indexOf("-");
    let index = indexPlus < indexMinus ? indexPlus : indexMinus;
    return parseInt(inputStr.substr(0,index));

}

function getOperation(inputStr: string) {

    let indexPlus = inputStr.indexOf("+");
    let indexMinus = inputStr.indexOf("-");

    return indexPlus < indexMinus ? "+" : "-";
}