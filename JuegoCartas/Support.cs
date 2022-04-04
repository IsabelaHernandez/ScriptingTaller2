using System;

public class Support : Carta
{
	string ET = "";
	int EP = 0;
	public int cantidad;

	Character character = new Character();
	private Character target;

	public Character jugador = new Character();
	public Character enemigo = new Character();

	public Support()
	{
		
	}

	public void AssignTarget(Character character)
	{
		target = character;
	}
	public void EffectSp()
	{
		if (target == jugador)
		{
			character.RP += 1;
		}
	
		if (target == enemigo)
		{
			character.AP -= 1;
			character.RP -= 1;

			character.equip = null;
		}
	}
}

