using YeldReturn.Minerador;

Console.Write("Digite quantas vezes você quer escavar no máximo para tentar achar o ouro: ");
var quantidadeMaxDeMineracao = Console.ReadLine();

foreach (var minerio in Minerador.Mineirar(Convert.ToInt32(quantidadeMaxDeMineracao)))
{   
    Console.WriteLine(minerio.Nome);
    if(minerio.Nome == "Ouro")
    {
        Console.WriteLine($"Achamos Ouro, estamos rico!");
        Console.WriteLine($"Você escavou {minerio.Codigo} vezes");
        break;
    }
}