interface IPerson {
    firstName: string;
    lastName: string;
    age: number;
    ssn?: string;
}

class Person {
    constructor(public config: IPerson) {        
    }
}

var aPerson: IPerson = {
    firstName: "John",
    lastName: "Smith",
    age: 29
}

class Employee extends Person {
    constructor(public config: IPerson) {
        super(config);
    }
}

var ePerson: IPerson = {
    firstName: "John",
    lastName: "Smith",
    age: 29,
    ssn: "123-90-4567"    
}

var p = new Person(aPerson);
console.log("Last name: " + p.config.lastName);

var e = new Employee(ePerson);
console.log("Last name: " + e.config.lastName  + " SSN: " + e.config.ssn);