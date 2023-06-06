using Esdc.Estruturas.Implementacoes.Pilhas;

namespace TestEsdc.TestesPilhas;

public class Tests
{
    [Test]
    public void Test_Push()
    {
        PilhaFixa<int> pilhaFixa = new PilhaFixa<int>(1);
        pilhaFixa.Push(2);
        Assert.That(pilhaFixa.Size(), Is.EqualTo(1));

        Assert.Throws<Exception>(() => { pilhaFixa.Push(1); });
    }

    [Test]
    public void Test_Pop()
    {
        PilhaFixa<int> pilhaFixa = new PilhaFixa<int>(1);

        pilhaFixa.Push(3);
        Assert.That(pilhaFixa.Pop, Is.EqualTo(3));

        Assert.Throws<Exception>(() => { pilhaFixa.Pop(); });
    }

    [Test]
    public void Test_Size()
    {
        PilhaFixa<int> pilhaFixa = new PilhaFixa<int>(10);
        Assert.That(pilhaFixa.Size(), Is.EqualTo(0));

        pilhaFixa.Push(2);
        pilhaFixa.Push(3);
        pilhaFixa.Push(4);

        Assert.That(pilhaFixa.Size(), Is.EqualTo(3));
    }

    [Test]
    public void Test_IsEmpty()
    {
        PilhaFixa<int> pilhaFixa = new PilhaFixa<int>(1);

        Assert.That(pilhaFixa.IsEmpty(), Is.EqualTo(true));
    }
}