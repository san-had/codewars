enum Action {
    Buy = 'BUY',
    Sell = 'SELL'
}

export function wordValue(arr: string[]) {
    const value = arr.map((word, index) => calculateValues(word, index));
    return value;
}

function calculateValues(word:string, index:number):number {
    const Offset = 96;
    // let sum = 0;
    // for(let index = 0; index < word.length; index++) {
    //     let value = word.charCodeAt(index) != 32 ? word.charCodeAt(index) - Offset : 0;
    //     sum += value;
    // }
    let sum = [...word.split('')].reduce((acc, el) => el !== ' ' ? acc + el.charCodeAt(0) - Offset : acc, 0);

    return sum * ++index;
}