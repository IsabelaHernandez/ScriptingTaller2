using System;

public class Support : Carta
{
	
	int EP = 1;
	public int cantidad;

	Character character = new Character();
	private Character target;

	public Character jugador = new Character();
	public Character enemigo = new Character();

	public enum EffectType
	{		
		ReduceAP, 
		ReduceRP, 
		ReduceAll, 
		DestroyEquip,
		RestoreRP
	}

	static Random random = new Random();
	static EffectType RandomEnumValue<EffectType>()
	{
		var values = Enum.GetValues(typeof(EffectType));
		return (EffectType)values.GetValue(random.Next(values.Length));
	}

	EffectType ETValue = RandomEnumValue<EffectType>();


	public Support()
	{
		
	}

	public void AssignTarget(Character character)
	{
		target = character;
	}
	public void EffectSp()
	{
		if (target == jugador && ETValue == EffectType.RestoreRP) 
		{
			character.RP += EP;
		}
	
		if (target == enemigo)
		{
			switch (ETValue)
            {
				case EffectType.ReduceAll:
					character.AP -= EP;
					character.RP -= EP;
					break;

				case EffectType.ReduceAP:
					character.AP -= EP;
					break;

				case EffectType.ReduceRP:
					character.RP -= EP;
					break;

				case EffectType.DestroyEquip:
					character.equip = null;
					break;

			}

			
		}
	}
}

