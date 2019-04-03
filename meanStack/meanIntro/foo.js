function Foo() {
    const privateMethod = () => console.log(this);
    this.greet = function() {
        console.log("hello!");
        privateMethod();
    }
}
