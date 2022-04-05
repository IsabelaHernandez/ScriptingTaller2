using System;

public class Support : Carta, IRandom
{
	Random aleatorio = new Random();

	public enum EffectType
	{
		ReduceAP,
		ReduceRP,
		ReduceAll,
		DestroyEquip,
		RestoreRP
	}

	int EP = 1;
	public int cantidad;

	Character character = new Character();
	private Character target;

	public Character jugador = new Character();
	public Character enemigo = new Character();
	static Random random = new Random();

	static EffectType RandomEffectTypeValue<EffectType>()
	{
		var values = Enum.GetValues(typeof(EffectType));
		return (EffectType)values.GetValue(random.Next(values.Length));
	}

	EffectType ETValue = RandomEffectTypeValue<EffectType>();

	public Support()
	{
		EP = aleatorio.Next(1, 7);
	}
	int RandomAtributtesValues(int delta)
	{
		var random = new Random(delta);
		var value = random.Next(0, 6);

		return value;
	}

	public void AssignTarget(Character character)
	{
		target = character;
	}

	public void EffectSp()
	{
		if (target == jugador && ETValue == EffectType.RestoreRP) 
		{
			character.rp += EP;
		}
	
		if (target == enemigo)
		{
			switch (ETValue)
            {
				case EffectType.ReduceAll:
					character.ap -= EP;
					character.rp -= EP;
					break;

				case EffectType.ReduceAP:
					character.ap -= EP;
					break;

				case EffectType.ReduceRP:
					character.rp -= EP;
					break;

				case EffectType.DestroyEquip:
					character.equip = null;
					break;

			}
		}
	}
}

