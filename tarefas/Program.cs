// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WritelLine("Preenchendo dados tarefa01");
var tarefas = new Tarefa ();
tarefa01.NOME ="Fazer compras";
tarefas.Descricao = "Comprar arroz,feijao e frutas";
tarefas.Datacriacao = DateTime.Now;
tarefas.Status =1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchindos");
Console.WriteLine("Inserindo dados no banco de dados");

var operacoes = new Opercoes();
int idInserindo = operacoes.Criar(tarefa01);

console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: {idInserido}");



