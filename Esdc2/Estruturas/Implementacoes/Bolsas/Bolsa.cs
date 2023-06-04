using Esdc2.Estruturas.Interfaces;

namespace Esdc2.Estruturas.Implementacoes.Bolsas;

public class Bolsa<T> : IBolsa<T>
{
    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }

    public int Size()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> AllVaLues()
    {
        throw new NotImplementedException();
    }
}