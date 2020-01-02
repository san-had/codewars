export function scoreHand(cards: string[]) {

    let cardValuesA1 : {[key:string] : number } = {};
    let cardValuesA11 : {[key:string]: number} = {};

    cardValuesA1 = SetupCardValues(1);
    cardValuesA11 = SetupCardValues(11);

    let valueWithA1: number = 0;
    let valueWithA11: number = 0;
    
    for (const card of cards) {
        valueWithA1 += cardValuesA1[card];
        valueWithA11 += cardValuesA11[card];
    }

    let below21 : number = 21 - valueWithA1;
    let above21 : number = valueWithA11 - 21;

    return below21 <= above21 ? valueWithA1 : valueWithA11;
}

function SetupCardValues(aValue: number) {

    let cardValues : {[key:string] : number } = {};
    for (let i = 2; i < 11; i++) {        
        cardValues[i.toString()] = i;
    }
    cardValues["J"] = 10;
    cardValues["Q"] = 10;
    cardValues["K"] = 10;
    cardValues["A"] = aValue;

    return cardValues;
}