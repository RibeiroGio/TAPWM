function validaInscricao() {

    var nome = document.getElementById('nome').value;
    var dataNascimento = document.getElementById('dataNascimento').value;
    var matriculado = document.querySelector('input[name="matriculado"]:checked').value;
    var endereco = document.getElementById('endereco').value;

    var dataNascimentoObj = new Date(dataNascimento);
    var hoje = new Date();
    var idade = hoje.getFullYear() - dataNascimentoObj.getFullYear();

    if ((idade >= 7 && idade <= 17) && matriculado === 'sim') {

        var inscricaoObj = {
            nome: nome,
            dataNascimento: dataNascimento,
            matriculado: matriculado,
            endereco: endereco
        };


        alert(`${inscricaoObj.nome} - ${inscricaoObj.dataNascimento} - ${inscricaoObj.endereco} - Está inscrito no torneio.`);
    } else {

        alert(`${nome} - ${dataNascimento} - ${endereco} - Não está inscrito no torneio porque não atende aos requisitos.`);
    }


    return false;
}

