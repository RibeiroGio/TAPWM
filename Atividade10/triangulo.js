var a = parseFloat(prompt("Informe um número A: "));
var b = parseFloat(prompt("Informe um número B: "));
var c = parseFloat(prompt("Informe um número C: "));

if(Number.isNaN(a, b, c)){
   alert("Por favor digite um número válido.")
}

  if(a + b > c && a + c > b && b + c > a){
     alert("Os números formam um triângulo.")

     if(a == b && a == c)
     alert("Os números formam triângulo Equilátero.")

     else if(a == b || a == c || b == c)
     alert("Os números formam triângulo Isósceles.")

     else
     alert("Os números formam triângulo Escaleno.")
  }

  else
  alert("Os números não formam um triângulo.")
