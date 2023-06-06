namespace Esdc.Utils;

public static class ErrorMessages
{
    public static string MaximumCapacity(string nomeDaEstrutura)
    {
        return $"Não é possível adicionar mais items na ${nomeDaEstrutura}, tamanho máximo já alcançado.";
    }

    public static string MinimumCapacity(string nomeDaEstrutura)
    {
        return $"Não é possível adicionar mais items na ${nomeDaEstrutura}, tamanho máximo já alcançado.";
    }

    public static string CreationUnderZero(string nomeDaEstrutura)
    {
        return $"Não é possível criar uma ${nomeDaEstrutura} com tamanho 0 ou negativo.";
    }
}