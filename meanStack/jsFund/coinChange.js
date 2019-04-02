function coinChange(param){
    if(typeof(param) == "number"){
        remain = param %100;
        dollar = Math.floor((param/100));
        param = remain;
        remain = param %25;
        quarter = Math.floor((param/25));
        param = remain;
        remain = param %10;
        dime = Math.floor((param/10));
        param = remain;
        remain = param %5;
        nickel = Math.floor((param/5));
        param = remain;
        pennies = param;
        console.log("Dollars: ", dollar, "Quarters: ", quarter,"Dime: ", dime, "Nickel: ", nickel, "Pennies: ", pennies);
    }
    else if(typeof(param) == "object"){
        var coinage = 0;
        for (let i in param) {
            console.log(i);
            if (i == "dollars"){
                coinage += 100*param[i];
            }
            else if(i == "quarters"){
                coinage += 25*param[i];
            }
            else if(i == "dimes"){
                coinage += 10*param[i];
            }
            else if(i == "nickels"){
                coinage += 5*param[i];
            }
            else if(i == "pennies"){
                coinage += param[i];
            }
        }
        coinChange(coinage);
    }
    else{
        console.log("gimme something better");
    }
}
coinChange({dollars: 2, dimes: 15, pennies: 5});
coinChange(282);