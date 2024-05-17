using InjecaoDependencia.Calculadora;

namespace InjecaoDependencia.Calculadora.Servicos;

public interface IServicoProduto
{
    public int RetornaId();
    public List<Produto> RetornaTodos();
    public void Add();
    public void Delete(int id);
}
