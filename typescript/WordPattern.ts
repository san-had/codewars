export function wordPattern(word: string): string {

    word = word.toLowerCase();

    let charStore: {[id: string]: number} = {};
    let patternList:number[] = [];
    
    let pattern = 0;
    let prevChar = " ";
    let wordChars = word.split('');
    for (let index = 0; index < wordChars.length; index++) {        
        if (index != 0 && prevChar != wordChars[index]) {
            pattern = Math.max(...patternList) + 1;
        }
        if (charStore[wordChars[index]] === undefined) {
            charStore[wordChars[index]] = pattern;            
            patternList.push(pattern);
        }
        else
        {
            pattern = charStore[wordChars[index]];
            patternList.push(pattern);
        }
        prevChar = wordChars[index];
    }    
    return patternList.join(".");
}