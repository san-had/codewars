interface IPayable {
    (percent: number): boolean;
}

class Person {
    constructor(private validator: IPayable) {        
    }

    increasePay(percent: number): boolean {
        return this.validator(percent);
    }
}

let forEmployees: IPayable = (percent) => {
    console.log("Increasing salary by ", percent);
    return true;    
}

let forContractors: IPayable = (percent) => {
    let increaseCap: number = 20;

    if (percent < increaseCap) {
        console.log("Increasing hourly rate by ", percent);
        return true;
    } else {
        console.log("Sorry, the increase cap for contractors is ", increaseCap);
        return false;
    }
}

let workers: Array<Person> = [];

workers[0] = new Person(forEmployees);
workers[1] = new Person(forContractors);

console.log("Running ...");


workers.forEach(worker => worker.increasePay(30));