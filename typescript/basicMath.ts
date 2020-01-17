export function calculate(inputStr: string) {

    while(inputStr.indexOf("plus") > 0) {
        inputStr = inputStr.replace("plus", "+");
    }

    while(inputStr.indexOf("minus") > 0) {
        inputStr = inputStr.replace("minus", "-");
    }    

    let result: string = inputStr;

    return result;
}