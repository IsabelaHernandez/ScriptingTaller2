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
}
