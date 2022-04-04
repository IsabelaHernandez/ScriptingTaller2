using System;

public class Carta
{
	string name = "";
	string[] rarity = new string[4] { "Common", "Rare", "SuperRare", "Ultra Rare" };
	int cp = 1;

	public Carta()
	{
		
	}
	public enum affinity
	{
		Knight,
		Mage,
		Undead
	}

	static Random random = new Random();
	static affinity RandomEnumValue<affinity>()
	{
		var values = Enum.GetValues(typeof(affinity));
		return (affinity)values.GetValue(random.Next(values.Length));
	}

	public affinity afinidadeq = RandomEnumValue<affinity>();
	public affinity afinidadch = RandomEnumValue<affinity>();
}
