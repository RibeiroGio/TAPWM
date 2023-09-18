var idadeSoma = 0;
var idadeMaisVelha = Number.MIN_VALUE;
var idadeMaisNova = Number.MAX_VALUE;
var mulheres = 0;
var homens = 0;
var quantidadePessimo = 0;
var quantidadeRegular = 0;
var quantidadeBom = 0;
var quantidadeOtimo = 0;
var totalRespostas = 0;

function processarResposta() {
    if (totalRespostas >= 45) {
        alert("Você atingiu o limite de 45 respostas.");
        return; 
    }

    var idade = parseInt(document.getElementById("idade").value);
    idadeSoma += idade;

    var sexo = document.querySelector('input[name="sexo"]:checked').value;
    if (sexo === 'masculino') {
        homens++;
    } else if (sexo === 'feminino') {
        mulheres++;
    }

    var opiniao = parseInt(document.getElementById("opiniao").value);
    switch (opiniao) {
        case 1:
            quantidadePessimo++;
            break;
        case 2:
            quantidadeRegular++;
            break;
        case 3:
            quantidadeBom++;
            break;
        case 4:
            quantidadeOtimo++;
            break;
    }

    if (idade > idadeMaisVelha) {
        idadeMaisVelha = idade;
    }
    if (idade < idadeMaisNova) {
        idadeMaisNova = idade;
    }

    totalRespostas++; 
    atualizarEstatisticas();
    document.getElementById("pesquisaForm").reset();
}

function atualizarEstatisticas() {
    var mediaIdade = idadeSoma / totalRespostas;
    var porcentagemBom = (quantidadeBom / totalRespostas) * 100;
    var porcentagemOtimo = (quantidadeOtimo / totalRespostas) * 100;

    document.getElementById("mediaIdade").textContent = mediaIdade.toFixed(2);
    document.getElementById("idadeMaisVelha").textContent = idadeMaisVelha;
    document.getElementById("idadeMaisNova").textContent = idadeMaisNova;
    document.getElementById("quantidadePessimo").textContent = quantidadePessimo;
    document.getElementById("quantidadeRegular").textContent = quantidadeRegular;
    document.getElementById("porcentagemBom").textContent = porcentagemBom.toFixed(2);
    document.getElementById("porcentagemOtimo").textContent = porcentagemOtimo.toFixed(2);
    document.getElementById("mulheres").textContent = mulheres;
    document.getElementById("homens").textContent = homens;
}