class Person {
    constructor(
        public firstName: string,
        public lastName: string,
        public age: number,
        private _ssn: string) {
    }

    get ssn():string {
        return this._ssn;
    }

    set ssn(value: string) {
        this._ssn = value;
    }
}

class Employee extends Person {
    department: string;
    constructor(firstName: string, lastName: string, age: number, _ssn:string, department: string) {
        super(firstName, lastName, age, _ssn);
        this.department = department;
    }
}

var p = new Person("John", "Smith", 29, "123-90-4567");
console.log("Last name: " + p.lastName + " SSN: " + p.ssn);

var e = new Employee("John", "Smith", 29, "123-90-4567", "HR");
console.log("Last name: " + e.lastName + " Department: " + e.department);

