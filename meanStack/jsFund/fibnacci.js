function fib() {
    // Some variables here
    var a=0;
    var b = 1;
    var c = 0;
    function nacci() {
      // do something to those variables here
      c= a + b;
      b = a;
      a = c;
      console.log(c);
      return c;
    }
    return nacci
  }
  var fibCounter = fib();
  fibCounter() // should console.log "1"
  fibCounter() // should console.log "1"
  fibCounter() // should console.log "2"
  fibCounter() // should console.log "3"
  fibCounter() // should console.log "5"
  fibCounter() // should console.log "8"
  fibCounter() // should console.log "8"
  fibCounter() // should console.log "8"
  fibCounter() // should console.log "8"
  fibCounter() // should console.log "8"
  fibCounter() // should console.log "8"
  fibCounter() // should console.log "8"