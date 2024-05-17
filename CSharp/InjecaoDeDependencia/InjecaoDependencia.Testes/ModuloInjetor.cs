using Microsoft.Extensions.DependencyInjection;
using InjecaoDependencia.Calculadora;
using InjecaoDependencia.Calculadora.Servicos;

namespace InjecaoDependencia.Testes;

public static class ModuloInjetor
{
   public static void InjetaDependencia(ServiceCollection Servicos)
   {
      Servicos.AddScoped<IServicoProduto, ServicoProduto>();
   }
}
