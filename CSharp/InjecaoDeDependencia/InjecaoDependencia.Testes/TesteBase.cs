using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;
using InjecaoDependencia.Calculadora;
using Moq;
using InjecaoDependencia.Calculadora.Servicos;

namespace InjecaoDependencia.Testes;

public class TesteBase : IDisposable
{
    protected ServiceProvider serviceProvider { get; set; }

    public TesteBase()
    {
        ServiceCollection servicos = new ServiceCollection();
        ModuloInjetor.InjetaDependencia(servicos);
        serviceProvider = servicos.BuildServiceProvider();
    } 

    [Fact]
    public void TestTestasda()
    {
        var coisa = serviceProvider.GetService<IServicoProduto>();

        int resultado = coisa.RetornaId();
        

        Assert.Equal(1231241414213412, resultado);
    }
    public void Dispose()
    {
        serviceProvider.Dispose(); 
    }

}
