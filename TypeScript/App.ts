let message : string = "Help me, Obi-Wan Kenobi. You're my onle hope!"
console.log(message)
let episode: number = 4
console.log("this is episode" + 4)
episode = episode + 1
console.log("Next episode is "+ episode)

let favoriteDroid
favoriteDroid = 'bb-8'
console.log("My favorite Droid is " + favoriteDroid)

let isEnoughtTobeatMF = function (parsecs: number): boolean{
    return parsecs < 12
} 

let distance = 11
console.log(`Is ${distance} parse enough to beat Millennium Falcon ? ${isEnoughtTobeatMF(distance)? 'YES':'NO'} `)

let callF = (name: string) => console.log(`Do you copy , ${name}`)
callF('R2')

function incremento (speed : number , inc: number = 1) : number{
    return speed + inc
}

console.log(`incremento (5,1) = ${incremento(5 ,1)}`)
console.log(`incremento (5) = ${incremento(5)}`)