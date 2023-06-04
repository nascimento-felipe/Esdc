namespace Esdc2.Estruturas.Interfaces;

public interface IFila<T>
{
    /// <summary>
    /// Adiciona um item à última posição do array.
    /// </summary>
    /// <param name="item">Item para ser adicionado na fila.</param>
    void Enqueue(T item);

    /// <summary>
    /// Retira o elemento que está em primieiro lugar na fila.
    /// </summary>
    /// <returns>O item retirado</returns>
    T Dequeue();

    /// <summary>
    /// Verifica se a fila está vazia.
    /// </summary>
    /// <returns><c>True</c> se a fila está vazia e <c>False</c> caso contrário.</returns>
    Boolean IsEmpty();

    /// <summary>
    /// Informa o tamanho da fila.
    /// </summary>
    /// <returns>O tamanho da fila.</returns>
    int Size();

    /// <summary>
    /// Iterator com todos os valores da fila.
    /// </summary>
    /// <returns>Todos os valores da fila, seguindo a ordem de inserção.</returns>
    IEnumerable<T> AllValues();
}