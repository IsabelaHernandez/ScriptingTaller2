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

	Random aleatorioep = new Random();
	static Random random = new Random();

	private int baseEP;
	//Character character = new Character();
	
	//Random Enum
	static TA RandomTAValue<TA>()
	{
		var values = Enum.GetValues(typeof(TA));
		return (TA)values.GetValue(random.Next(values.Length));
	}

	TA TAValue = RandomTAValue<TA>();

	public Equip( int ep)
	{
		EP = ep;		
	}

	public int EP
	{
		get => baseEP;
		private set => baseEP = value;
	}

	public void EffectEq()
	{
		switch (TAValue)
        {
			case TA.AP:
				character.ap += EP;
				
				break;

			case TA.RP:
				character.rp += EP;
				break;

			case TA.ALL:
				character.ap += EP;
				character.rp += EP;
				break;
        }	
		
	}

	public void AffinityEq()
	{

	}
}

