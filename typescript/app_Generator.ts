function* doSomething() {
    console.log("Started processing");
    yield;
    console.log("Resumed processing");        
}

var iterator = doSomething();

//let value = iterator.next();