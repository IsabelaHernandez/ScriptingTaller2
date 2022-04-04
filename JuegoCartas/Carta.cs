using System;

public class Carta
{
	public enum Affinity
	{
		Knight,
		Mage,
		Undead
	}

	string name = "";
	string[] rarity = new string[4] { "Common", "Rare", "SuperRare", "Ultra Rare" };
	int CP = 1;

	static Random random = new Random();

	public Carta()
	{
		
	}	

	static affinity RandomAffinityValue<affinity>()
	{
		var values = Enum.GetValues(typeof(affinity));
		return (affinity)values.GetValue(random.Next(values.Length));
	}

	public Affinity afinidadEq = RandomAffinityValue<Affinity>();
	public Affinity afinidadCh = RandomAffinityValue<Affinity>();
}
