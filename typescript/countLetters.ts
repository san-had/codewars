export function letter_count(inputString: string) {

    let letterCount : { [ key: string ] : number; } = {};

    for (let letter of inputString.split('').sort((x,y) => x > y ? 1 : -1)) {
        let value = inputString.split('').filter(ch => ch === letter).length;
            letterCount[letter] = value;
        };

    return letterCount;
}