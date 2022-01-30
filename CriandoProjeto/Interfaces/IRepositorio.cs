using System.Collections.Generic;
namespace CriandoProjeto.Interfaces
{
  public interface IRepositorio<T>
  {
    List<T> Lista();
    T RetornaPorId(int id);
    void Insere(T entidade);
    void Exclui(int id);
    void Atualiza(int id, Serie entidade);
    int ProximoId();

  }
}