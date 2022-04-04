using System;

public class Equip : Carta
{
	Character character = new Character();
	public int cantidad;
	int EP = 1;	
	//public affinity afinidadeq = AffinityValue;

	public enum TA
    {
		AP,
		RP,
		ALL
    }

	static Random random = new Random();
	static TA RandomEnumValue<TA>()
	{
		var values = Enum.GetValues(typeof(TA));
		return (TA)values.GetValue(random.Next(values.Length));
	}

	TA TAvalue = RandomEnumValue<TA>();

	public Equip()
	{
		
	}

	public void EffectEq()
	{
		switch (TAvalue)
        {
			case TA.AP:
				character.AP += EP;
				break;

			case TA.RP:
				character.RP += EP;
				break;

			case TA.ALL:
				character.AP += EP;
				character.RP += EP;
				break;
        }
		
		
		
	}

	public void AffinityEq()
	{

	}
}

