export function getColumnNumbers(array : string[]) {

    let result: string[] = [];

    for (let i = 0; i < array.length; i++) {
        let ch : string = (i + 1).toString() + ": " + array[i];
        result.push(ch);
    }
    return result;
}

export function getColumnNumbers2(array: string[]) {
    return array.map((v, i) => `${i + 1}: ${v}`);
}