using CrudAspNetCoreDapper.Entities;
using System.Collections.Generic;

namespace CrudAspNetCoreDapper.Repository
{
    public interface IProdutoRepository
    {
        int Add(Produto produto);
        List<Produto> GetProdutos();
        Produto GetProdutoId(int id);
        int Edit(Produto produto);
        int Delete(int id);
    }
}
