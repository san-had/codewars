import { Student } from "./Student";

export function mostMoney(students: Student[]) {

    let reducedStudentArray: reducedStudent[] = students.map(student => 
        {
            const money: number = student.fives * 5 + student.tens * 10 + student.twenties * 20;
            return new reducedStudent(student.name, money);
        });

    let maxMoney: number = Math.max(...reducedStudentArray.map(student => student.money));

    let numberOfMaxMoney : number = reducedStudentArray
        .filter(student => student.money == maxMoney).length;

    return numberOfMaxMoney > 1 
        ? "all" 
        : reducedStudentArray.filter(student => student.money == maxMoney)[0].name;

}

class reducedStudent {
    constructor(public name: string, public money: number ) {
    }
}