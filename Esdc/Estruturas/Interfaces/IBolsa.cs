namespace Esdc.Estruturas.Interfaces;

public interface IBolsa<T>
{
    /// <summary>
    /// Adiciona um novo item à bolsa.
    /// </summary>
    /// <param name="item">Item para ser adicionado.</param>
    void Add(T item);

    /// <summary>
    /// Verifica se a bolsa está vazia.
    /// </summary>
    /// <returns><c>True</c> se a bolsa está vazia e <c>False</c> caso contrário.</returns>
    Boolean IsEmpty();

    /// <summary>
    /// Informa o tamanho da bolsa.
    /// </summary>
    /// <returns>O tamanho da bolda.</returns>
    int Size();

    /// <summary>
    /// Iterator com todos os valores da bolsa.
    /// </summary>
    /// <returns>Todos os valores da bolsa, seguindo a ordem de inserção.</returns>
    IEnumerable<T> AllVaLues();
}