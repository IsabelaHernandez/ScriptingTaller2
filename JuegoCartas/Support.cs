using System;

public class Support : Carta
{

	public enum EffectType
	{
		ReduceAP,
		ReduceRP,
		ReduceAll,
		DestroyEquip,
		RestoreRP
	}

	Random aleatorioep = new Random();
	static Random random = new Random();

	Character character = new Character();
	private Character target;
	private int baseEP;

	public Character jugador = new Character();
	public Character enemigo = new Character();

	//Random Enum
	static EffectType RandomEffectTypeValue<EffectType>()
	{
		var values = Enum.GetValues(typeof(EffectType));
		return (EffectType)values.GetValue(random.Next(values.Length));
	}

	EffectType ETValue = RandomEffectTypeValue<EffectType>();

	public Support(int ep)
	{
		EP = ep;
	}

	public int EP
	{
		get => baseEP;
		private set => baseEP = value;
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

