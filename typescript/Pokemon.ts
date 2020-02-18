export function calculateDamage(yourType:string, opponentType:string, attack:number, defense:number) {
    let damage: number = 50 * (attack / defense) * getEffectiveness(yourType, opponentType);

    return damage;
}

function getEffectiveness(yourType:string, opponentType:string): number {

    let effectiveness: number = 1;
    let effectivenesses = loadEffectiveness();
    let key: string = yourType + "-" + opponentType;

    if (effectivenesses[key] !== undefined) {
        effectiveness = effectivenesses[key];
    }
    
    return effectiveness;
}

function loadEffectiveness(): any {
    let effectivenessDictionary : { [ key: string ] : number; } = {};

    effectivenessDictionary["electric-water"] = 2;
    effectivenessDictionary["fire-grass"] = 2;
    effectivenessDictionary["water-fire"] = 2;
    effectivenessDictionary["grass-water"] = 2;

    effectivenessDictionary["water-electric"] = 0.5;
    effectivenessDictionary["grass-fire"] = 0.5;
    effectivenessDictionary["fire-water"] = 0.5;
    effectivenessDictionary["water-grass"] = 0.5;

    return effectivenessDictionary;
}