function procura(texto) {
    var textoMinusc = texto.toLowerCase();

    var contadorA = 0;
    for (var i = 0; i < textoMinusc.length; i++) {
        if (textoMinusc[i] === 'a') {
            contadorA++;
        }
    }

    console.log(`Quantidade de letras 'A' encontradas: ${contadorA}`);
}

procura("A leitura é um ramo da aprendizagem fundamental para a formação de estudantes como cidadaos. Essa habilidade deve ser incentivada, pois desenvolve o conhecimento de mundo do aluno, o pensamento critico, vocabulário, praticas sociais e a imaginação, alem de ampliar o conhecimento cultural");

