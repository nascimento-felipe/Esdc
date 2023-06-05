namespace Esdc.Estruturas.Interfaces;

public interface IPilha<T>
{
    /// <summary>
    /// Adiciona um novo item à pilha.
    /// </summary>
    /// <param name="item">Item para ser adicionado à pilha.</param>
    void Push(T item);

    /// <summary>
    /// Remove o último item da pilha.
    /// </summary>
    /// <returns> Retorna o item excluído da pilha.</returns>
    T Pop();

    /// <summary>
    /// Verifica se a pilha está vazia
    /// </summary>
    ///
    /// <returns>
    /// Retorna <c>True</c> se a pilha estiver vazia e <c>False</c> caso contrário
    /// </returns>
    Boolean IsEmpty();

    /// <summary>
    /// Retorna o tamanho da pilha
    /// </summary>
    ///
    /// <returns>
    /// Retorna o tamanho
    /// </returns>
    int Size();

    /// <summary>
    /// Iterator com todos os valores da pilha.
    /// </summary>
    /// <returns>Todos os valores da pilha, seguindo a ordem de inserção.</returns>
    IEnumerable<T> AllItems();
}