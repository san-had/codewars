export function MoonRating(rating: number): string {
    const moonrate: number = 0.5 * rating;
    let fullMoon: number = Math.floor(moonrate);
    let frac: number = moonrate - fullMoon >= 0.75 ? 1 : moonrate - fullMoon >= 0.25 ? 0.5 : 0;
    if (frac == 1) {
        fullMoon += 1;
        frac = 0;
    }

    const fullmoonString = "o";

    let result = "";
    for(let i = 1; i < 6; i++) {
        if (fullMoon - i >= 0) {
            result += "o";
            continue;
        }
        if (frac > 0) {
            result += "c";
            frac = 0;
            continue;
        }
        result += "x";
    } 
    return result;
}