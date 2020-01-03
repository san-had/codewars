export function scoreHand(cards: string[]) {

    let numberOfAces : number = cards.filter(x => x == "A").length;

    let cardValues : {[key:string] : number } = {};

    cardValues = SetupCardValues();

    let values: number = 0;
    
    for (const card of cards.filter(x => x != "A")) {
        values += cardValues[card];
    }

    for (let i = 0; i < numberOfAces; i++ ) {
        if (values < 21) {
            if (21 - values >= 11 + (numberOfAces - 1)) {
                values += 11;
            } else {
                values += 1;
            }
        } else {
            values += 1;
        }
    }
    return values;
}

function SetupCardValues() {

    let cardValues : {[key:string] : number } = {};
    for (let i = 2; i < 11; i++) {        
        cardValues[i.toString()] = i;
    }
    cardValues["J"] = 10;
    cardValues["Q"] = 10;
    cardValues["K"] = 10;

    return cardValues;
}