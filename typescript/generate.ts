export function generateRange(min:number, max:number, step:number) {

   const integers : any[] = []; 

    for (let i = min; i <= max; i += step) {
        integers.push(i);
    }
    return integers;
}