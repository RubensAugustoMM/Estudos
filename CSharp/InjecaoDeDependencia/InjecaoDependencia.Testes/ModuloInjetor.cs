using Microsoft.Extensions.DependencyInjection;
using InjecaoDependencia.Calculadora;

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
      _servico.AddTransient<ICalculador, Calculador>();
        return _servico.BuildServiceProvider();
     }
}
