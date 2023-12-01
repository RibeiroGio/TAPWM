function ordena(n1, n2, n3, n4, n5) {
    var num = [n1, n2, n3, n4, n5];

    num.sort(function(a, b) {
      return b - a;
    });

    console.log("Números em ordem decrescente:", num);
  }


  ordena(5, 2, 8, 1, 3);