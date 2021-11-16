namespace Dados.Contexto
{
    public interface IContextoBanco
    {
        void Conectar();
        void Desconectar();
    }
}