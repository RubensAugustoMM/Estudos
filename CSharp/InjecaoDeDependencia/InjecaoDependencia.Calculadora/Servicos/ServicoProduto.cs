using System;
using System.Collections.Generic;

//https://medium.com/@eugene_s/better-unit-tests-in-c-with-xunit-87c6abf7970a
//https://github.com/devlooped/moq/wiki/Quickstart
//https://xunit.net/
namespace InjecaoDependencia.Calculadora.Servicos;

public class ServicoProduto : IServicoProduto
{
    public int RetornaId()
    {
        return 1232145;
    }

    public List<Produto> RetornaTodos()
    {
        return null;
    }
    public List<Produto> RetornaTodos(int i)
    {
        List<Produto> produtos = new();
        return produtos;
    }

    public void Add()
    {

    }

    public void Delete(int id)
    {

    }
}
