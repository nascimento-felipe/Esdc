using Esdc.Estruturas.Implementacoes.Filas;

namespace TestEsdc.TestesFilas;

public class TesteFilaFixa
{
    [Test]
    public void Test_Enqueue()
    {
        FilaFixa<int> fila = new FilaFixa<int>(1);
        fila.Enqueue(2);
        Assert.That(fila.Size(), Is.EqualTo(1));

        Assert.Throws<Exception>(() => { fila.Enqueue(1); });
    }

    [Test]
    public void Test_Dequeue()
    {
        FilaFixa<int> fila = new FilaFixa<int>(1);

        fila.Enqueue(3);
        Assert.That(fila.Dequeue(), Is.EqualTo(3));

        Assert.Throws<Exception>(() => { fila.Dequeue(); });
    }

    [Test]
    public void Test_Size()
    {
        FilaFixa<int> fila = new FilaFixa<int>(10);
        Assert.That(fila.Size(), Is.EqualTo(0));

        fila.Enqueue(2);
        fila.Enqueue(3);
        fila.Enqueue(4);

        Assert.That(fila.Size(), Is.EqualTo(3));
    }

    [Test]
    public void Test_IsEmpty()
    {
        FilaFixa<int> fila = new FilaFixa<int>(1);

        Assert.That(fila.IsEmpty(), Is.EqualTo(true));
    }
}