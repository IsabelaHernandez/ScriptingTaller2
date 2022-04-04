using System;

public class Equip : Carta
{
	Character character = new Character();
	public int cantidad;
	int EP = 0;	
	public affinity afinidadeq = affinity.Knight;

	//string[] TAarray = new string[3] { "AP", "RP", "ALL" };
	//Random rnd = new Random();
	//int index = rnd.Next(TAarray.Length);
	//string TA = "";

	public enum TA
    {
		AP,
		RP,
		ALL
    }

	Array values = Enum.GetValues(typeof(TA));
	Random random = new Random();
	TA randomTA = (TA)values.GetValue(random.Next(values.Length));


	public Equip()
	{
		
	}

	public void EffectEq()
	{
		switch (TAarray)
        {
			case TA[0]:
				character.AP += 1;
				break;

			case "RP":
				character.RP += 1;
				break;

			case "ALL":
				character.AP += 1;
				character.RP += 1;
				break;
        }

		
		
	}

	public void AffinityEq()
	{

	}
}

