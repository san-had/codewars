export function wordPattern(word: string): string {

    word = word.toLowerCase();

    let charStore: {[id: string]: number} = {};
    let patternList:number[] = [];
    
    let pattern = 0;
    let wordChars = word.split('');
    wordChars.forEach((letter: string) => {
        if(charStore[letter] === undefined) {
            charStore[letter] = pattern++;
        }
        patternList.push(charStore[letter]);
    })
    return patternList.join(".");
}