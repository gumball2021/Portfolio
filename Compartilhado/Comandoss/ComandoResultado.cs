namespace SistemCadastro.Compartilhado.Comandoss
{
    public class ComandoResultado:IComandoResultado
    {
        public ComandoResultado(bool sucesso, string mensagem, object data=null)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Data = data;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Data { get; set; }
    }
    
}
