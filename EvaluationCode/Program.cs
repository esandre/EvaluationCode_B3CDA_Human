using System.Numerics;

for (uint rang = 0; rang < 100; rang++)
    Console.WriteLine($"Rang {rang} : " + Factorielle.CalculerPourRang(rang));

public class Factorielle
{
    private Factorielle()
    {
        Rang = 0;
        Valeur = 1;
    }

    private Factorielle(Factorielle précédente)
    {
        Rang = précédente.Rang + 1;
        Valeur = précédente.Valeur * Rang;
    }

    public static Factorielle Zéro = new ();

    public Factorielle Supérieure => new (this);
    public uint Rang { get; }
    public BigInteger Valeur { get; }

    public static Factorielle CalculerPourRang(uint rang)
        => rang == 0
            ? Zéro
            : CalculerPourRang(rang - 1).Supérieure;

    /// <inheritdoc />
    public override string ToString() => Valeur.ToString();
}