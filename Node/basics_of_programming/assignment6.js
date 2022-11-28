var customer = { Name: undefined};

try {
    customer.PrintOrder();
} catch(e) {
    console.log("Customer does not have order method");
    console.log(e.name);
}

try {
    let variable = 0;
    if(variable === 0) {
        // We can throw our own exceptions
        throw new Error('Something terrible happened.');
    }
} catch(e) {
    // Print outs only the message of exception
    console.log(e.message);
    console.log(e.name);
}