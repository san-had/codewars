export const getAverage = (marks:number[]):number =>
    Math.floor(marks.reduce((a: number,b: number) => a + b) / marks.length);


console.log(getAverage([1,2,3,4,5,6,7,8]));
