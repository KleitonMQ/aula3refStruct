using static System.Console;

class Aula3
{
    static void Main()
    {
        WriteLine("Hello, World!");
        Pessoa p1 = new Pessoa();
        p1.nome = "Ricardo";
        p1.idade = 30;
        p1.enderecoPessoa = new Endereco()
        {
            logradouro = "Rua teste",
            numero = 300,
            cep = "00000",
            cidade = "Cedro",
        };

    }
}
