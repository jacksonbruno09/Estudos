/** Usando Classe e interface**/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Spacecraft = /** @class */ (function () {
    //construtor da classe
    function Spacecraft(propulsor) {
        this.propulsor = propulsor;
    }
    //metodo
    Spacecraft.prototype.JumpIntHyperSpace = function () {
        console.log("Entering hyperspace with " + this.propulsor);
    };
    return Spacecraft;
}());
//instanciar classe
var ship = new Spacecraft('hiperDrive');
ship.JumpIntHyperSpace();
//------------------------------------------------------
// herança
var MilleniumFalcon = /** @class */ (function (_super) {
    __extends(MilleniumFalcon, _super);
    function MilleniumFalcon() {
        return _super.call(this, 'hyperdrive') || this;
    }
    MilleniumFalcon.prototype.JumpIntHyperSpace = function () {
        if (Math.random() >= 0.5) {
            _super.prototype.JumpIntHyperSpace.call(this);
        }
        else {
            console.log('Failend to jump into hyperspace');
        }
    };
    return MilleniumFalcon;
}(Spacecraft));
var falcon = new MilleniumFalcon();
falcon.JumpIntHyperSpace();
var MilleniumFalcon2 = /** @class */ (function (_super) {
    __extends(MilleniumFalcon2, _super);
    function MilleniumFalcon2() {
        var _this = _super.call(this, 'hyperdrive') || this;
        _this.cargoContainers = 2;
        return _this;
    }
    MilleniumFalcon2.prototype.JumpIntHyperSpace = function () {
        if (Math.random() >= 0.5) {
            _super.prototype.JumpIntHyperSpace.call(this);
        }
        else {
            console.log('Failend to jump into hyperspace');
        }
    };
    return MilleniumFalcon2;
}(Spacecraft));
var falcon2 = new MilleniumFalcon2();
falcon2.JumpIntHyperSpace();
var goodForTheJob = function (ship) { return ship.cargoContainers > 2; };
console.log("Is falcon good for the job? " + (goodForTheJob(falcon2) ? 'Yes' : 'No'));
