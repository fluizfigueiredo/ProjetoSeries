using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornoPorId(int id);
        void Insere(T entidade);
        void Exclui(int Id);
        void Atualiza(int Id, T entidade);
        int ProximoId();
    }
}