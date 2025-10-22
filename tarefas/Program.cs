// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Preenchendo dados tarefa 01");
var tarefa01 = new Tarefa();
tarefa01.Nome = "Fazer compras";
tarefa01.Descricao  = "Comprar arroz, feijão e frutas";
tarefa01.DataCriacao = DateTime.Now; 
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserindo dados no banco de dados");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: {idInserido}");