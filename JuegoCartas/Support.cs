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

	private int baseEP;

	//Random Enum
	static EffectType RandomEffectTypeValue<EffectType>()
	{
		var values = Enum.GetValues(typeof(EffectType));
		return (EffectType)values.GetValue(random.Next(values.Length));
	}

	EffectType ETValue = RandomEffectTypeValue<EffectType>();

	public Support(int ep, int cp)
	{
		EP = ep;
		CP = cp;
	}

	public int EP
	{
		get => baseEP;
		private set => baseEP = value;
	}

	public void EffectSp(Character character)
	{
		if (ETValue == EffectType.RestoreRP) 
		{
			character.ModifyRP((int)EP);
		}
	
		else
		{
			switch (ETValue)
            {
				case EffectType.ReduceAll:
					character.target.ModifyAP(-(int)EP);
					character.target.ModifyRP(-(int)EP);
					break;

				case EffectType.ReduceAP:
					character.target.ModifyAP(-(int)EP);
					break;

				case EffectType.ReduceRP:
					character.target.ModifyRP(-(int)EP);
					break;

				case EffectType.DestroyEquip:
					EP = 0;
					character.target.DisassociatedEquip();

					break;

			}
		}
	}
}

