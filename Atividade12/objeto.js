
// usandoo construtor
var aluno1 = new Object();
aluno1.ra = "00001234";
aluno1.nome = "Giovanna";
alert("ra = " + aluno1.ra + " nome = " + aluno1.nome);

// usando {}
var aluno2 = {};
aluno2.ra = "1234";
aluno2["nome"] = "Giovanna";
//aluno2.nome="Kaylla"
alert("ra = " + aluno2.ra + " nome = " + aluno2.nome);

//literal 

var aluno3 = {
    ra: "1234567",
    nome: "Giovanna"
};
alert("ra = " + aluno3.ra + " nome = " + aluno3.nome);

// função construtora

function Aluno(ra, nome) {
    this.ra = ra;
    this.nome = nome;

    this.MostraDados = function () {
        return "ra = " + this.ra + " nome = " + this.nome;
    }

}
var aluno4 = new Aluno("12222", "Giovanna");
alert(aluno4.MostraDados());

function Aluno2() {
    var ra;
    var nome;
    this.setRa = function (value) {
        this.ra = value;
    }
    this.getRa = function () {
        return this.ra;
    }
    this.setNome = function (value) {
        this.nome = value;
    }
    this.getNome = function () {
        return this.nome;
    }  
}
var aluno5 = new Aluno2();
aluno5.setNome("Giovanna");
aluno5.setRa("3333");
alert("ra = " + aluno5.getRa() + " nome = "+ aluno5.getNome());