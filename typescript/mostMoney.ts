import { Student } from "./Student";

export function mostMoney(students: Student[]) {

    let reducedStudentArray: reducedStudent[] = students.map(student => 
        {
            const money: number = student.fives * 5 + student.tens * 10 + student.twenties * 20;
            return new reducedStudent(student.name, money);
        });

    let numberOfMaxMoney : number = reducedStudentArray
        .filter(student => student.money == Math.max(student.money)).length;
    

}

class reducedStudent {
    constructor(public name: string, public money: number ) {

    }
}