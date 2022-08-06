using AulaBD;

// C:\Users\71888\Desktop\BD.txt
string[] pessoas = File.ReadAllLines(@"C:\Users\71888\Desktop\BD.txt");

List<string> elementos = Comandos.ToList(pessoas);

while (true)
{
    Console.WriteLine("Cadastro de pessoas:");
    Console.WriteLine("Insia o nome da pessoa, ou 'fim' para sair");
    Console.WriteLine();
    string nome = Console.ReadLine();

    if (nome.ToLower() == "fim")
    {
        Console.WriteLine("Obrigado por trabalhar conosco, Srta. Margot");
        break;
    }
    Console.WriteLine("Insira a idade da pessoa: ");
    string idade = Console.ReadLine();
    Console.WriteLine("Insira o CPF da pessoa: ");
    string cpf = Console.ReadLine();
    bool cpfValido = true;
    foreach (var item in elementos)
    {
        string[] dados = item.Split('|');
        if (dados[2] == cpf)
        {
            cpfValido = false;
            break;
        }
    }
    if (cpfValido)
    {
        Console.WriteLine("Informe o RG da pessoa");
        string rg = Console.ReadLine();
        elementos.Add($"{nome}{idade}{cpf}{rg}");
    }
    else
    {
        Console.WriteLine("CPF ja cadastrado");

    }

}
var outputs = elementos.ToArray();

File.WriteAllLines(@" C:\Users\71888\Desktop\BD.txt", outputs);