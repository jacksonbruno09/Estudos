/** Usando Classe e interface**/

class Spacecraft {

    //construtor da classe
    constructor (public propulsor: string){}

    //metodo
    JumpIntHyperSpace(){
        console.log(`Entering hyperspace with ${this.propulsor}`)
    }
}

//instanciar classe
let ship = new Spacecraft('hiperDrive')
ship.JumpIntHyperSpace()

//------------------------------------------------------
// herança
class MilleniumFalcon extends Spacecraft{
    constructor(){
        super('hyperdrive')
    }

    JumpIntHyperSpace(){
        if(Math.random() >= 0.5){
            super.JumpIntHyperSpace()
        }else{ console.log('Failend to jump into hyperspace')}
    }
}

let falcon = new MilleniumFalcon()
falcon.JumpIntHyperSpace()


//---------------------------------------------------
// interface

interface Containership {

    cargoContainers: number
}

class MilleniumFalcon2 extends Spacecraft implements Containership{

    cargoContainers: number

    constructor(){
        super('hyperdrive')
        this.cargoContainers = 2
    }

    JumpIntHyperSpace(){
        if(Math.random() >= 0.5){
            super.JumpIntHyperSpace()
        }else{ console.log('Failend to jump into hyperspace')}
    }
}

let falcon2 = new MilleniumFalcon2()
falcon2.JumpIntHyperSpace()

let goodForTheJob = (ship: Containership) => ship.cargoContainers > 2

console.log(`Is falcon good for the job? ${goodForTheJob (falcon2)? 'Yes' : 'No'}`)

