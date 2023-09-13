var user = 0;//usuário
var pc = Math.random();//pc

user = prompt("Digite o nº de acordo com sua escolha: \n1=Pedra \n2=Papel \n3=Tesoura");


// 1 pedra  // 2 pape 3 tesoura
if (pc <=  0.33) {
   pc = 1;
   
} 

else if (pc >= 0.33 && pc <= 0.66) {
    pc = 2;
    
}

else if (pc >= 0.66 && pc <= 0.99) {
    pc = 3;
    
} else {
    alert('Erro 404 :)');
}


 if (user == pc) {
     alert (" Empate");
 }
 else if(user==1 && pc==3){
    alert("Pedra quebra tesoura, usuario venceu");
}
else if(user==3 && b==2){
    alert("Tesoura corta papel, usuario venceu");
}
else if(user==2 && pc==1){
    alert("Papel cobre a pedra, usuario venceu");
}
else if(pc==1 && user==3){
    alert("Pedra quebra tesoura, o pc venceu");
}
else if(pc==3 && user==2){
    alert("Tesoura corta papel, o pc venceu");
}
else if(pc==2 && user==1){
    alert("Papel cobre a pedra, o pc venceu");
}



