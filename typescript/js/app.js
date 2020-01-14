"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Student_1 = require("./Student");
var mostMoney_1 = require("./mostMoney");
var andy = new Student_1.Student("Andy", 0, 0, 2);
var stephen = new Student_1.Student("Stephen", 0, 4, 0);
var eric = new Student_1.Student("Eric", 8, 1, 0);
var david = new Student_1.Student("David", 2, 0, 1);
var phil = new Student_1.Student("Phil", 0, 2, 1);
var cam = new Student_1.Student("Cameron", 2, 2, 0);
var geoff = new Student_1.Student("Geoff", 0, 3, 0);
console.log(mostMoney_1.mostMoney([andy, stephen, eric, david, phil]));
console.log(mostMoney_1.mostMoney([cam, geoff, andy, stephen, eric, david, phil]));
console.log(mostMoney_1.mostMoney([andy]));
console.log(mostMoney_1.mostMoney([stephen]));
console.log(mostMoney_1.mostMoney([cam, geoff]));
console.log(mostMoney_1.mostMoney([david, cam, geoff]));
//# sourceMappingURL=app.js.map