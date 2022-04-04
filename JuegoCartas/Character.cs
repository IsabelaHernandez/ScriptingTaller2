using System;

public class Character : Carta
{
	public int AP = 0;
	public int RP = 1;
	public int cantidad;
	affinity afinidad = affinity.Knight;

	 public Equip equip = new Equip(); 

	public Character()
	{
		
	}

	public void AttackPointsCh()
	{

	}

	public void EquipCh(Equip targetEquip)
	{

		// Organizar 3 slots 

		for (int i = 0; i < 3; i++)
		{

			if (targetEquip != null)
			{
				if (afinidad == targetEquip.afinidadeq)
				{
					equip = targetEquip;
				}
			}

		}
	}

	public void AffinityCh()
	{

	}

}
