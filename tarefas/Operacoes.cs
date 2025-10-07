public class  Operacoes{
    private string connectionString ="";
    public int criar (Tarefa tarefa)
    {
        using(var conexao= new MySqlConnction(connectionString))
        {
            conexao.Open();
            string sql = @ INSERT INTO tarefa (nome,descriscao,datacriacao,status,dataExercucao)
            VALUES (@nome,@descriscao,@dataCriacao,@status,@dataExercucao);
            SELECT LAST_INSERT_ID();";
            using(var cmd = new MySqlCommand(sql,conexao))
            {
                cmd.Parameters.AddwithValue("@nome",tarefa.Nome);
                cmd.Parameters.AddwithValue("@descricao",tarefa.Descricao);
                cmd.Parameters.AddwithValue("@dataCriacao",tarefa.DataCriacao);
                cmd.Parameters.AddwithValue("@status",tarefa.Status);
                cmd.Parameters.AddwithValue("@dataExecucao",tarefa.DataExecucao);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        return 0;
    }
 public Tarefa   Buscar(int id)
 {
 return null;
 }
 public List<Tarefa> Listar ()
 {
    return Array.Empty<Tarefa>();
 }
 public void Alterar(Tarefa  tarefa)
 {
 }
 public void Excluir (int id)
 {

 }
}