namespace YeldReturn.Minerador;

using YeldReturn.Minerio;

public static class Minerador
{
    public static IEnumerable<Minerio> Mineirar(int quantidade)
    {
        int count = 1;
        Random random = new Random();
        var localizacaoDoOuro = random.Next(1, 1000);
       while(true)
       {
        yield return new Minerio()
        {
            Codigo = count,
            Nome = count == localizacaoDoOuro ? "Ouro" : "Ferro"
        };
        count++;
        if(count == quantidade) yield break;
       }
    }
}