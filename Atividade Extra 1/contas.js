function contas() {
    var num = new Array(3);
    num[0] = parseFloat(prompt("Informe um valor a: "));
    num[1] = parseFloat(prompt("Informe um valor b: "));
    num[2] = parseFloat(prompt("Informe um valor c: "));

    var soma = num[0] + num[1] + num[2];
    var quadrado1 = num[0] * num[0];
    var quadrado2 = num[1] * num[1];

    if (Number.isNaN(num[0], num[1], num[2])) {
        alert("Por favor digite um número válido.");
    }
    alert("A soma dos valores é: " + soma + ".")
    alert("O quadrado do primeiro valor é: " + quadrado1 + ".")
    alert("O quadrado do segundo valor é: " + quadrado2 + ".")
}

contas();


