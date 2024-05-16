using Microsoft.Extensions.DependencyInjection;

namespace InjecaoDependencia.Testes;

public class ModuloInjetor 
{
     private ServiceCollection _servico; 

     public ModuloInjetor()
     {
        _servico = new ServiceCollection();
     }

     public ServiceProvider ConstroiServiceProvider()
     {
      _servico.AddTransient<ICalculadora, Calculadora>();
        return _servico.BuildServiceProvider();
     }
}
public interface ICalculadora
{
    /*
    public decimal adicao();
    public decimal subtracao();
    public decimal divisao();
    public decimal multiplicacao();
    */
}
public class Calculadora : ICalculadora 
{
    /*
    public decimal adicao()
    {
        return 1;
    }
    public decimal subtracao()

    public decimal divisao();
    public decimal multiplicacao();
    */
}
