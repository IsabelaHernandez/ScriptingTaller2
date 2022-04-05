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

	public void EffectEq(Character target)
	{
		switch (TAValue)
        {
			case TA.AP:
				target.ModifyAP((int)EP); 
				
				break;

			case TA.RP:
				target.ModifyRP((int)EP);
				break;

			case TA.ALL:				
				target.ModifyAP((int)EP);
				target.ModifyRP((int)EP);
				break;
        }	
		
	}

	public void AffinityEq()
	{

	}
}

