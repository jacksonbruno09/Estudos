var message = "Help me, Obi-Wan Kenobi. You're my onle hope!";
console.log(message);
var episode = 4;
console.log("this is episode" + 4);
episode = episode + 1;
console.log("Next episode is " + episode);
var favoriteDroid;
favoriteDroid = 'bb-8';
console.log("My favorite Droid is " + favoriteDroid);
var isEnoughtTobeatMF = function (parsecs) {
    return parsecs < 12;
};
var distance = 11;
console.log("Is " + distance + " parse enough to beat Millennium Falcon ? " + (isEnoughtTobeatMF(distance) ? 'YES' : 'NO') + " ");
var callF = function (name) { return console.log("Do you copy , " + name); };
callF('R2');
function incremento(speed, inc) {
    if (inc === void 0) { inc = 1; }
    return speed + inc;
}
console.log("incremento (5,1) = " + incremento(5, 1));
console.log("incremento (5) = " + incremento(5));
