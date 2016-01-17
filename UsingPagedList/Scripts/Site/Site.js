function remover(id) {
    $.getJSON("Fornecedor/Remover", { id: id }, function(data) {
        var tabela = "    <thead> <th></th> <th>Nome</th> <th>CNPJ</th> <th>Email</th> <th></th> </thead> <tbody>";
        for (var i = 0; i < data.dados.length; i++) {
            tabela += "<tr><td class='text-center'> <a href='/Fornecedor/Editar?id=" + data.dados[i].Id + "'><div class='glyphicon glyphicon-edit' ></div></a></td>";
            tabela += "<td>" + data.dados[i].Nome + "</td>";
            tabela += "<td>" + data.dados[i].CNPJ + "</td>";
            tabela += "<td>" + data.dados[i].Email + "</td>";
            tabela += "<td class='text-center'> <a href='#'><div class='glyphicon glyphicon-remove' onclick='remover(" + data.dados[i].Id + ")'></div></a></td></tr>";
        }
        tabela += "</tbody>";
        $("#tabelaFornecedores").html(tabela);
    });

}
