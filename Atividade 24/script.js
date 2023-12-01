function dividir(a, b) {
    var resultado = a / b;

    if (isNaN(resultado)) {
      console.log("Divisão deu NaN");
    } else if (!isFinite(resultado)) {

      console.log("Divisão de Infinity");
    } else {

      console.log(`Resultado da divisão: ${resultado}`);
    }
  }

  dividir(91919, 7);
  dividir(0, 0);
  dividir(9, 0);
  dividir("sim", 2);