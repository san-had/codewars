export function divisors(n: number) {
    let divisorsCount = 0;
    for(let index = 1; index <= n; index++) {
        if( n % index === 0) {
            divisorsCount++;
        }
    }
    return divisorsCount;
}