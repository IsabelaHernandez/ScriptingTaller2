using System;

public class Equip : Carta
{
	//Target Atributtes:
	public enum TA
	{
		AP,
		RP,
		ALL
	}

	public int cantidad; //Cantidad de cartas de tipo Equip en el Deck
	int EP = 1;
	//public Affinity afinidadeq = AffinityValue;

	Character character = new Character();
	static Random random = new Random();

	static TA RandomTAValue<TA>()
	{
		var values = Enum.GetValues(typeof(TA));
		return (TA)values.GetValue(random.Next(values.Length));
	}

	TA TAValue = RandomTAValue<TA>();

	public Equip()
	{
		//El constructor solo lo usariamos si decidimos usar el get y set para las variables
	}

	public void EffectEq()
	{
		switch (TAValue)
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

