
function encontrarMaiorNumero() {
    var num1 = parseFloat(prompt("Digite o primeiro número:"));
    var num2 = parseFloat(prompt("Digite o segundo número:"));
    var num3 = parseFloat(prompt("Digite o terceiro número:"));
    var num4 = parseFloat(prompt("Digite o quarto número:"));

    var maior = Math.max(num1, num2, num3, num4);

    alert("O maior número é: " + maior);
}
encontrarMaiorNumero();

function ordenarNumerosCrescente() {
    var num1 = parseFloat(prompt("Digite o primeiro número:"));
    var num2 = parseFloat(prompt("Digite o segundo número:"));
    var num3 = parseFloat(prompt("Digite o terceiro número:"));
    var num4 = parseFloat(prompt("Digite o quarto número:"));

    var numeros = [num1, num2, num3, num4];

    numeros.sort(function (a, b) {
        return a - b;
    });

    alert("Números ordenados em ordem crescente: " + numeros.join(", "));
}

ordenarNumerosCrescente();