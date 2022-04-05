using System;

public class Character : Carta 
{
	//public int ap = 0;
	//public int rp = 0;

	public bool fullequiped = false;

	private int baseAP;
	private int baseRP;


	private Equip slot1;
	private Equip slot2;
	private Equip slot3;

	public Character target;

	private Equip associatedEquip;

	
	public Character(int ap, int rp, int cp)
	{
		//Random atributos

		AP = ap;
		RP = rp;
		CP = cp;
	
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

	public void DisassociatedEquip()
    {
		if (slot3 != null)
        {
			slot3 = null;
        }
		else if (slot2 != null)
		{
			slot2 = null;
		}
		else if (slot1 != null)
		{
			slot1 = null;
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
					AssociatedEquip(targetEquip);
				}
			}

		}
	} 

	public void ModifyRP(int delta) 
	{
		RP += delta;
	}

	public void ModifyAP(int delta)
	{
		AP += delta;
	}


	public void AssignTarget(Character character)
	{
		target = character;
	}


	public void AffinityCh(Character target)
	{
		if ((afinidadCh == Affinity.Knight && target.afinidadCh == Affinity.Mage)|| (afinidadCh == Affinity.Mage && target.afinidadCh == Affinity.Undead)||(afinidadCh == Affinity.Undead && target.afinidadCh == Affinity.Knight))
        {
			ModifyAP(1);
			target.ModifyAP(-1);
        }

		if ((target.afinidadCh == Affinity.Knight && afinidadCh == Affinity.Mage) || (target.afinidadCh == Affinity.Mage && afinidadCh == Affinity.Undead) || (target.afinidadCh == Affinity.Undead && afinidadCh == Affinity.Knight))
        {
			ModifyAP(-1);
			target.ModifyAP(1);
		}
	}

}
