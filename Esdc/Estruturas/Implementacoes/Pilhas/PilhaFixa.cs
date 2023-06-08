using System.Text;
using Esdc.Estruturas.Interfaces;

namespace Esdc.Estruturas.Implementacoes.Pilhas;

/// <summary>
/// Estrutura de dados que funciona com a lógica FILO. Essa classe tem um array não redimensionável.
/// </summary>
public class PilhaFixa<T> : IPilha<T>
{
    /// <summary>
    /// Array de items com os valores da pilha.
    /// </summary>
    private T?[] items;

    /// <summary>
    /// Tamanho da pilha.
    /// </summary>
    private int size;

    /// <summary>
    /// Construtor principal da classe
    /// </summary>
    /// <param name="tamanho">Tamanho da pilha</param>
    ///
    public PilhaFixa(int tamanho)
    {
        items = new T[tamanho];
        size = 0;
    }


    public void Push(T? item)
    {
        items[size++] = item;
    }


    public T? Pop()
    {
        return items[--size];
    }


    public Boolean IsEmpty()
    {
        return size == 0;
    }


    public int Size()
    {
        return size;
    }

    public IEnumerable<T?> AllItems()
    {
        foreach (T? value in items)
        {
            yield return value;
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

        for (int i = 0; i < size; i++)
        {
            s.Append(items[i] + " -> ");
        }

        s.Append("Fim da pilha.");

        return s.ToString();
    }
}