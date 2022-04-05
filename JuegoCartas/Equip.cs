using System;

public class Equip : Carta, IRandom
{

	Random aleatorio = new Random();

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
		EP = aleatorio.Next(1, 7);

		//El constructor solo lo usariamos si decidimos usar el get y set para las variables
	}

	int RandomAtributtesValues(int delta)
	{
		var random = new Random(delta);
		var value = random.Next(0, 6);

		return value;
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

