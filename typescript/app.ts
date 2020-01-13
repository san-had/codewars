import { Student } from "./Student";
import { mostMoney } from "./mostMoney";

const andy = new Student("Andy", 0, 0, 2);
const stephen = new Student("Stephen", 0, 4, 0);
const eric = new Student("Eric", 8, 1, 0);
const david = new Student("David", 2, 0, 1);
const phil = new Student("Phil", 0, 2, 1);
const cam = new Student("Cameron", 2, 2, 0);
const geoff = new Student("Geoff", 0, 3, 0);

console.log(mostMoney([andy, stephen, eric, david, phil]));

console.log(mostMoney([cam, geoff, andy, stephen, eric, david, phil]));

