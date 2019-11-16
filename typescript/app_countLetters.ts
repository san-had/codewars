import { letter_count } from "./countLetters";

let letterDictionary = letter_count('arithmetic');

for(let key in letterDictionary) {
      console.log(" " + key + ": " + letterDictionary[key]);      
}