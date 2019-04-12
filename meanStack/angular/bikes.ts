class Bike {
    miles: number
    constructor(
        public price: number,
        public max_speed: number
    ){
        this.miles = 0;
    }
    displayInfo = () =>{
        console.log(`Price: ${this.price}, Max Speed: ${this.max_speed}, Miles: ${this.miles}`);
        return this;
    }
    ride = () => {
        console.log("Riding!");
        this.miles += 10;
        return this;
    }
    reverse = () => {
        console.log("Reversing");
        this.miles -= 5;
        return this;
    }
}