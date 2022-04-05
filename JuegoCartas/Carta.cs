using System;

public abstract class Carta 
{
	public enum Affinity
	{
		Knight,
		Mage,
		Undead
	}

	public string name = "";
	public string[] rarity = new string[4] { "Common", "Rare", "SuperRare", "Ultra Rare" };
	public int CP = 1;

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
