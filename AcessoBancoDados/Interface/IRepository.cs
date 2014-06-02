using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBancoDados.Interface
{
    public interface IRepository<T> where T : class
    {
        string Salvar(T entidade);
        string Excluir(T entidade);
        IList<T> BuscarId(int id);
        IList<T> BuscarNome(string arg);
        IList<T> BuscarTodos();
    }
}