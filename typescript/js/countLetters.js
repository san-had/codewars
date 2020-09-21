"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function letter_count(inputString) {
    var letterCount = {};
    var _loop_1 = function (letter) {
        var value_1 = inputString.split('').filter(function (ch) { return ch === letter; }).length;
        letterCount[letter] = value_1;
    };
    for (var _i = 0, _a = inputString.split('').sort(function (x, y) { return x > y ? 1 : -1; }); _i < _a.length; _i++) {
        var letter = _a[_i];
        _loop_1(letter);
    }
    ;
    return letterCount;
}
exports.letter_count = letter_count;
//# sourceMappingURL=countLetters.js.map