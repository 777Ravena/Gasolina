Console.Clear();

decimal Etanol, Gasolina, razao;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- ETANOL OU GASOLINA ---");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Digite o preço do Etanol (R$).....:");
Etanol = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o preço do Gasolina (R$).....:");
Gasolina = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

razao = RazaoEtanolGasolina(Etanol, Gasolina);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"O preço do etanol corresponde a {(razao * 100):N1}% do preço da gasolina.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Recomendação: Abasteça com {(AbastecerComGasolina(razao) ? "GASOLINA" : "ETANOL")}");
Console.ResetColor();

decimal RazaoEtanolGasolina(decimal valorEtanol, decimal valorGasolina)
{
    return valorEtanol / valorGasolina;
}

bool AbastecerComGasolina(decimal razao)
{
    const decimal percentualIdeal = 0.73M;
    return razao > percentualIdeal;
}