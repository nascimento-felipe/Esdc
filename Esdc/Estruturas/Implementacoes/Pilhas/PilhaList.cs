using Esdc.Estruturas.Interfaces;

namespace Esdc.Estruturas.Implementacoes.Pilhas;

public class PilhaList<T> : IPilha<T>
{
    /// <summary>
    /// O elemento do topo da pilha.
    /// </summary>
    private Node<T?>? first;

    /// <summary>
    /// Tamanho da pilha.
    /// </summary>
    private int size;

    /// <summary>
    /// Classe de nó que auxilia a pilha.
    /// </summary>
    /// <typeparam name="U">Tipo da pilha.</typeparam>
    private class Node<U>
    {
        /// <summary>
        /// Item do nó.
        /// </summary>
        public U? item;

        /// <summary>
        /// Próximo elemento da lista, ligado ao nó.
        /// </summary>
        public Node<U>? next;
    }

    /// <summary>
    /// Adiciona um elemento à lista
    /// </summary>
    /// <param name="item">Item para ser adicionado</param>
    public void Push(T? item)
    {
        Node<T?>? oldFirst = first;
        first = new Node<T?>();
        first.item = item;
        first.next = oldFirst;
        size++;
    }

    /// <summary>
    /// Retira o elemento do topo da pilha.
    /// </summary>
    /// <returns>O elemento do topo da pilha.</returns>
    public T? Pop()
    {
        if (first == null)
        {
            throw new Exception();
        }

        T? item = first.item;
        first = first.next;
        size--;
        return item;
    }
    
    // Ja comentado na interface
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Ja comentado na interface
    public int Size()
    {
        return size;
    }

    // Ja comentado na interface
    public IEnumerable<T> AllItems()
    {

        if (first == null)
        {
            yield return default(T);
        }
        else
        {
            Node<T> current = first;

            while (current != null)
            {
                var item = current;
                current = current.next;
                yield return item.item;
            }
        }
    }
}