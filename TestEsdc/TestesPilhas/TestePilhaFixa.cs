using Esdc.Estruturas.Implementacoes.Pilhas;

namespace TestEsdc.TestesPilhas;

// TODO: Criar testes dessa classe

public class Tests
{
    [Test]
    public void Test_Push()
    {
        PilhaFixa<int> pilhaFixa = new PilhaFixa<int>(10);
        pilhaFixa.Push(2);
        Assert.That(pilhaFixa.Size(), Is.EqualTo(1));
    }

    [Test]
    public void Test_Pop()
    {
        PilhaFixa<int> pilhaFixa = new PilhaFixa<int>(10);

        pilhaFixa.Push(3);
        Assert.That(pilhaFixa.Size(), Is.EqualTo(1));
        int value = pilhaFixa.Pop();
        Assert.That(pilhaFixa.Size(), Is.EqualTo(0));
        Assert.That(value, Is.EqualTo(3));
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
}