"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var countLetters_1 = require("./countLetters");
var letterDictionary = countLetters_1.letter_count('arithmetic');
for (var key in letterDictionary) {
    console.log(" " + key + ": " + letterDictionary[key]);
}
//# sourceMappingURL=app_countLetters.js.map