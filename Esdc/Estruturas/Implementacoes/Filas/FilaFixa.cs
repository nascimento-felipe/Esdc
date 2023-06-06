using System.Text;
using Esdc.Estruturas.Interfaces;
using Esdc.Utils;

namespace Esdc.Estruturas.Implementacoes.Filas;

// TODO: [ ] Fazer a documentação dessa classe

public class FilaFixa<T> : IFila<T>
{
    private T[] items;
    private int size;
    private int tail;
    private int head;

    public FilaFixa(int tamanho)
    {
        if (tamanho <= 0)
        {
            throw new ArgumentOutOfRangeException("tamanho",
                ErrorMessages.CreationUnderZero("fila"));
        }

        items = new T[tamanho];
        size = 0;
        head = 0;
        tail = 0;
    }

    public void Enqueue(T item)
    {
        if (size + 1 > items.Length)
        {
            throw new Exception(ErrorMessages.MaximumCapacity("fila"));
        }

        size++;
        items[ReturnMod(tail++)] = item;
    }

    public T Dequeue()
    {
        if (size == 0)
        {
            throw new Exception(ErrorMessages.MinimumCapacity("fila"));
        }

        size--;
        return items[ReturnMod(head++)];
    }

    public Boolean IsEmpty()
    {
        return size == 0;
    }

    public int Size()
    {
        return size;
    }

    public IEnumerable<T> AllValues()
    {
        foreach (T item in items)
        {
            yield return item;
        }
    }

    /// <summary>
    ///  Representação da pilha por meio de setas, apontando do começo até o final da pilha.
    /// </summary>
    ///
    /// <returns>
    /// Uma representação da pilha em forma de String. O retorno vem da seguinte forma:
    /// <code>
    ///  0 -> 0 -> {...} -> Fim da lista.
    /// </code>
    /// </returns>
    public override string ToString()
    {
        StringBuilder s = new StringBuilder();

        for (int i = ReturnMod(head); i < ReturnMod(tail); i++)
        {
            s.Append(items[i] + " -> ");
        }

        s.Append("Fim da fila.");

        return s.ToString();
    }

    private int ReturnMod(int valor)
    {
        if (valor == 0) return 0;

        return valor % items.Length;
    }
}