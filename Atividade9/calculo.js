

var peso = parseFloat(prompt("Digite seu peso: "));
var altura = parseFloat(prompt("Digite sua altura: "));
var total = Math.round(peso / Math.pow(altura, 2), 1);


if (total < 18.5) {
    alert("Seu IMC é: " + total + ". Você está abaixo da média!, isso é MUITO perigoso");
}
else if (total >= 18.5 && total <= 24.9) {
    alert("Seu IMC é: " + total + ". Você está na média, isso é bom!");
}
else if (total >= 25.0 && total <= 29.9) {
    alert("Seu IMC é: " + total + ". Você está em sobrepeso, tome cuidado!")
}
else if (total >= 30.0 && total <= 39.9) {
    alert("Seu IMC é: " + total + ". Você está na obesidade, isso é perigoso!")
}
else if (total > 40) {
    alert("Seu IMC é: " + total + ". Você está na obesidade grave, isso é MUITO perigoso!")
}