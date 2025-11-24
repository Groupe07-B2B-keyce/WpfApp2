// Electronique.cs
using System;

public class Electronique : Article
{
	public int GarantieMois { get; set; }

	public Electronique(string nom, decimal prix, int garantie) : base(nom, prix)
	{
		GarantieMois = garantie;
	}

	public override void AfficherDetails()
	{
		Console.WriteLine($"Electro: {Nom}, Garantie: {GarantieMois} mois, Prix: {Prix}€");
	}
}