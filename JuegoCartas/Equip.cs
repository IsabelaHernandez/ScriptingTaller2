using System;

public class Equip : Carta
{
	Character character = new Character();
	public int cantidad;
	int EP = 0;
	string TA = "";

	public Equip()
	{
		
	}

	public void EffectEq()
	{
		character.AP += 1;
		character.RP += 1;
	}

	public void AffinityEq()
	{

	}
}

