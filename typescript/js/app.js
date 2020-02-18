"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Pokemon_1 = require("./Pokemon");
console.log(Pokemon_1.calculateDamage("fire", "water", 100, 100));
console.log(Pokemon_1.calculateDamage("grass", "water", 100, 100));
console.log(Pokemon_1.calculateDamage("electric", "fire", 100, 100));
console.log(Pokemon_1.calculateDamage("grass", "electric", 57, 19));
console.log(Pokemon_1.calculateDamage("grass", "water", 40, 40));
console.log(Pokemon_1.calculateDamage("grass", "fire", 35, 5));
console.log(Pokemon_1.calculateDamage("fire", "electric", 10, 2));
//# sourceMappingURL=app.js.map