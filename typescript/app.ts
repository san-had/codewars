import { calculateDamage } from "./Pokemon";

console.log(calculateDamage("fire", "water", 100, 100));
console.log(calculateDamage("grass", "water", 100, 100));
console.log(calculateDamage("electric", "fire", 100, 100));
console.log(calculateDamage("grass", "electric", 57, 19));
console.log(calculateDamage("grass", "water", 40, 40));
console.log(calculateDamage("grass", "fire", 35, 5));
console.log(calculateDamage("fire", "electric", 10, 2));