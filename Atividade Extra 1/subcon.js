function subconjuto() {
    var palavra1, palavra2;

    palavra1 = prompt("Informe a primeira palavra: ");
    palavra2 = prompt("Informe a segunda palavra: ");


    if (!palavra1 || !palavra2) {
        alert("Erro! Por favor digite uma palavra.");
    }
    else if (palavra1.includes(palavra2)) {
        alert("A segunda palavra é um subconjunto da primeira");
    }
    else {
        alert("A segunda palavra não é um subconjunto da primeira")
    }
}

subconjuto();