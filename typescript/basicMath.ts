export function calculate(inputStr: string) {

    while(inputStr.indexOf("plus") > 0) {
        inputStr = inputStr.replace("plus", "+");
    }

    while(inputStr.indexOf("minus") > 0) {
        inputStr = inputStr.replace("minus", "-");
    }

    let total: number = getItem(inputStr);

    do {
        let operation: string = getOperation(inputStr);

        let item: number = getItem(inputStr);

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
    return firstItem;
}

function getOperation(inputStr: string) {

    let indexPlus = getOperationIndex(inputStr, "+");
    let indexMinus = getOperationIndex(inputStr, "-");
    let index = indexPlus < indexMinus ? indexPlus : indexMinus;
    inputStr = inputStr.substr(index + 1);
    return indexPlus < indexMinus ? "+" : "-";
}

function getOperationIndex(inputStr: string, operationStr: string) {
    return inputStr.indexOf(operationStr) != -1
     ? inputStr.indexOf(operationStr) 
     : 999999;
}