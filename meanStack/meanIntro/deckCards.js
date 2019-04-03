class Card{
    constructor(suit, name, val){
        this.suit = suit;
        this.name = name;
        this.val = val;
        console.log("Card constructor");
    }
    show(){
        console.log(`This Card is the ${this.name} of ${this.suit}s`)
    }
}

class Deck{
    constructor() {
        this.deck = this.reset();
    }
    shuffle(){
        console.log(this.deck);
        console.log("Got to shuffle");
        var m = this.deck.length;
        console.log(m);
        var t;
        var i;
        while(m) {
            i = Math.floor(Math.random() * m--);

            t = this.deck[m];
            this.deck[m] = this.deck[i];
            this.deck[i] = t;
        }
        return this.deck;
    }
    reset(){
        this.deck = [];
        const suits = ['Hearts', 'Spades', 'Clubs', 'Diamonds'];
        const names = ['Ace', 2, 3, 4, 5, 6, 7, 8, 9, 10, 'Jack', 'Queen', 'King'];
        let val = 1;
        for (let suit in suits) {
            val = 1;
            for (let name in names)
            {
                let card = new Card(suits[suit], names[name], val);
                console.log(card);
                this.deck.push(card);
                val++;
            }
        }
        return this.deck;
    }
    deal(){
        return this.deck.pop();
    }
}

class Player{
    constructor(name){
        this.name = name;
        this.hand = [];
    }
    take(deck){
        let card = deck.deal();
        console.log("You drew", card);
        return this.hand.push(card);
    }
    discard(){
        return this.hand.pop();
    }
}

var deck1 = new Deck();
deck1.shuffle();
var dude = new Player("Jeremy");
