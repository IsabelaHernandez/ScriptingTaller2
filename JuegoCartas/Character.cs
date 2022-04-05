using System;

public class Character : Carta 
{

	Random aleatorio = new Random();

	public int ap = 0;
	public int rp = 0;

	public int cantidad;
	public bool fullequiped = false;

	private int baseAP;
	private int baseRP;
	private int baseCP;

	public Equip equip = new Equip();

	private Equip slot1;
	private Equip slot2;
	private Equip slot3;

	private Equip associatedEquip;

	public Character()
	{
		//Random atributos
		AP = aleatorio.Next(1, 6);
		RP = aleatorio.Next(1, 6);
		CP = aleatorio.Next(1, 6);
	}

	public int AP
	{
		get => baseAP;
		private set => baseAP = value;
		
	}

	public int RP
	{
		get => baseRP;
		private set => baseRP = value;
	}


	/*public Character( int ap, int rp, int cp)
    {
		AP = ap;
		RP = rp;
		CP = cp;
    } */


	public void AttackPointsCh()
	{

	}

	public void AssociatedEquip(Equip equip)
    {
		associatedEquip = equip;

		if (slot1 == null)
        {
			slot1 = associatedEquip;
        }

		else if (slot2 == null)
		{
			slot2 = associatedEquip;
		}

		else if (slot3 == null)
		{
			slot3 = associatedEquip;
		}

		else
        {
			fullequiped = true;
        }

	}


	public void EquipCh(Equip targetEquip)
	{

		while (fullequiped == false)
		{
			if (targetEquip != null)
			{
				if (afinidadCh == targetEquip.afinidadEq)
				{
					//equip = targetEquip;
					AssociatedEquip(targetEquip);
				}
			}

		}
	}

	public void AffinityCh()
	{

	}

}
