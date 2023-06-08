using Esdc.Estruturas.Interfaces;

namespace Esdc.Estruturas.Implementacoes.Pilhas;

public class PilhaResize<T> : IPilha<T>
{
    /// <summary>
    /// Array de itens que representa a pilha.
    /// </summary>
    private T?[] items = new T?[1];

    /// <summary>
    /// Tamanho da pilha.
    /// </summary>
    private int size = 0;

    /// <summary>
    /// Método responsável por aumentar ou diminuir a pilha, conforme for passado nos parâmetros.
    /// </summary>
    /// <param name="max">Novo tamanho da pilha.</param>
    private void Resize(int max)
    {
        T?[] temp = new T[max];

        for (int i = 0; i < size; i++)
        {
            temp[i] = items[i];
        }

        items = temp;
    }

    /// <summary>
    ///  Adiciona um novo item à pilha.
    /// </summary>
    /// <param name="item">Item que será adicionado à pilha.</param>
    public void Push(T? item)
    {
        if (size == items.Length)
        {
            Resize(2 * items.Length);
        }

        items[size++] = item;
    }

    /// <summary>
    /// Retira um item do topo da pilha.
    /// </summary>
    /// <returns>O item do topo da pilha.</returns>
    public T? Pop()
    {
        T? item = items[--size];
        items[size] = default(T);

        if (size > 0 && size == items.Length / 4)
        {
            Resize(items.Length / 2);
        }

        return item;
    }

    /// <summary>
    /// Verifica se a pilha está vazia.
    /// </summary>
    /// <returns><c>True</c> se a pilha está vazia e <c>False</c> caso contrário.</returns>
    public bool IsEmpty()
    {
        return size == 0;
    }

    /// <summary>
    /// Verifica o tamanho da pilha.
    /// </summary>
    /// <returns>O tamanho da pilha na forma de <c>int</c></returns>
    public int Size()
    {
        return size;
    }

    /// <summary>
    /// Retorna um iterator com todos os itens da pilha.
    /// </summary>
    /// <returns>Todos os itens da pilha.</returns>
    public IEnumerable<T?> AllItems()
    {
        foreach (T? item in items)
        {
            yield return item;
        }
    }
}