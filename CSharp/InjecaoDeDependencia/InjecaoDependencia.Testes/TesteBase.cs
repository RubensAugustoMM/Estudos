using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System;
using Xunit;
using InjecaoDependencia.Calculadora;

namespace InjecaoDependencia.Testes;

public class TesteBase : IDisposable
{
    protected ServiceProvider serviceProvider { get; set; }

    public TesteBase()
    {
        var ModuloInjetor = new ModuloInjetor();
        serviceProvider = ModuloInjetor.ConstroiServiceProvider();
    }

    [Fact]
    public void Calculador32adiciona8()
    {
        var adicinador = serviceProvider.GetService<ICalculador>();
        decimal resultado = adicinador.adicao(2, 3);

        Assert.Equal(resultado, 8);
    }

    public void Dispose()
    {
        serviceProvider.Dispose(); 
    }

}