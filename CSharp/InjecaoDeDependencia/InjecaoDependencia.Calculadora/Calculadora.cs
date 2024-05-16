namespace InjecaoDependencia.Calculadora;

public interface ICalculador
{
    public decimal adicao(decimal i, decimal j);
    public decimal subtracao(decimal i, decimal j);
    public decimal divisao(decimal i, decimal j);
    public decimal multiplicacao(decimal i, decimal j);

}
public class Calculador : ICalculador 
{
    public decimal adicao(decimal i,decimal j)
    {
        return i;
    }
    public decimal subtracao(decimal i, decimal j)
    {
        return j;
    }

    public decimal divisao(decimal i, decimal j)
    {
        return i;
    }
    public decimal multiplicacao(decimal i, decimal j)
    {
        return j;
    }
}
