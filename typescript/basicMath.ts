export function calculate(inputStr: string) {

    while(inputStr.indexOf("plus") > 0) {
        inputStr = inputStr.replace("plus", "+");
    }

    while(inputStr.indexOf("minus") > 0) {
        inputStr = inputStr.replace("minus", "-");
    }

    let firstItemTuple: [number, string] = getItem(inputStr);
    let total: number = firstItemTuple[0];
    inputStr = firstItemTuple[1];

    do {
        let operationTuple: [string, string] = getOperation(inputStr);
        let operation: string = operationTuple[0];
        inputStr = operationTuple[1];

        let itemTuple: [number, string] = getItem(inputStr);
        let item: number = itemTuple[0];
        inputStr = getItem(inputStr)[1];

        if (operation == "+") {
            total += item;
        } else {
            total -= item;
        }   
    } while (inputStr.length > 0)

    let result: string = total.toString();

    return result;
}

function getItem(inputStr:string) {

    let indexPlus = getOperationIndex(inputStr, "+");
    let indexMinus = getOperationIndex(inputStr, "-");
    let index = indexPlus < indexMinus ? indexPlus : indexMinus;
    let firstItem = parseInt(inputStr.substr(0,index));
    inputStr = inputStr.substr(index);
    let itemTuple: [number, string] = [firstItem, inputStr];
    return itemTuple;
}

function getOperation(inputStr: string) {

    let indexPlus = getOperationIndex(inputStr, "+");
    let indexMinus = getOperationIndex(inputStr, "-");
    let index = indexPlus < indexMinus ? indexPlus : indexMinus;
    inputStr = inputStr.substr(index + 1);
    let operation: string = indexPlus < indexMinus ? "+" : "-";
    let operationTuple: [string, string] = [operation, inputStr];
    return operationTuple;
}

function getOperationIndex(inputStr: string, operationStr: string) {
    return inputStr.indexOf(operationStr) != -1
     ? inputStr.indexOf(operationStr) 
     : 999999;
}