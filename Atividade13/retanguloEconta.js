function Retangulo(x, y, tipo){
  this.x = x
  this.y = y
  this.tipo = tipo
  this.area = x * y

  this.MostraDados = function(){
    return "A área do retângulo é: " + this.area + this.tipo;
  }
}

const retangulo1 = new Retangulo(
    parseFloat(prompt("Insira um valor x: ")),
    parseFloat(prompt("Insira um valor y: ")),
    prompt("Insira o tipo de medida: "))
    alert(retangulo1.MostraDados());


    function Conta() {
        this.nomeCorrentista;
        this.banco;
        this.numeroDaConta;
        this.saldo;
    
        this.setNomeCorrentista = function(value) {
            this.nomeCorrentista = value;
        }
        this.getNomeCorrentista = function() {
            return this.nomeCorrentista;
        }
        this.setBanco = function(value) {
            this.banco = value;
        }
        this.getBanco = function() {
            return this.banco;
        }
        this.setNumeroDaConta = function(value) {
            this.numeroDaConta = value;
        }
        this.getNumeroDaConta = function() {
            return this.numeroDaConta;
        }
        this.setSaldo = function(value) {
            this.saldo = value;
        }
        this.getSaldo = function() {
            return this.saldo;
        }
    }
    
    function Corrente() {
        Conta.call(this);
        this.saldoEspecial;
    
        this.setSaldoEspecial = function(value) {
            this.saldoEspecial = value;
        }
        this.getSaldoEspecial = function() {
            return this.saldoEspecial;
        }
    }
    
    Corrente.prototype = Object.create(Conta.prototype);
    
    function Poupanca() {
        Conta.call(this);
        this.juros;
        this.dataVencimento;
    
        this.setJuros = function(value) {
            this.juros = value;
        }
        this.getJuros = function() {
            return this.juros;
        }
        this.setDataVencimento = function(value) {
            this.dataVencimento = value;
        }
        this.getDataVencimento = function() {
            return this.dataVencimento;
        }
    }

    Poupanca.prototype = Object.create(Conta.prototype);
    
    var contaCorrente = new Corrente();
    contaCorrente.setNomeCorrentista(prompt("Informe seu nome: "));
    contaCorrente.setBanco(prompt("Informe seu banco: "));
    contaCorrente.setNumeroDaConta(parseFloat(prompt("Informe o número da conta: ")));
    contaCorrente.setSaldo(parseFloat(prompt("Informe o saldo da conta: ")));
    contaCorrente.setSaldoEspecial(parseFloat(prompt("Informe seu saldo especial: ")) + contaCorrente.getSaldo());
    
    alert("Nome: " + contaCorrente.getNomeCorrentista() + "\nBanco: " + 
        contaCorrente.getBanco() + "\nNúmero da conta: " + 
        contaCorrente.getNumeroDaConta() + "\nSaldo: " + contaCorrente.getSaldo() + 
        "\nSaldo especial: " + contaCorrente.getSaldoEspecial());
    
    var contaPoupanca = new Poupanca();
    contaPoupanca.setNomeCorrentista(prompt("Informe seu nome: "));
    contaPoupanca.setBanco(prompt("Informe seu banco: "));
    contaPoupanca.setNumeroDaConta(parseFloat(prompt("Informe o número da conta: ")));
    contaPoupanca.setSaldo(parseFloat(prompt("Informe o saldo da conta: ")));
    contaPoupanca.setJuros(parseFloat(prompt("Informe a taxa de juros: ")));
    contaPoupanca.setDataVencimento(prompt("Informe a data de vencimento: "));
    contaPoupanca.saldoComJuros = (contaPoupanca.getSaldo() * contaPoupanca.getJuros()) + contaPoupanca.getSaldo();
    
    alert("Nome: " + contaPoupanca.getNomeCorrentista() + "\nBanco: " + 
        contaPoupanca.getBanco() + "\nNúmero da conta: " + 
        contaPoupanca.getNumeroDaConta() + "\nSaldo: " + contaPoupanca.getSaldo() + 
        "\nTaxa de juros: " + contaPoupanca.getJuros() + "\nData de vencimento: " + contaPoupanca.getDataVencimento() + 
        "\nSaldo com taxa: " + contaPoupanca.saldoComJuros);
    

