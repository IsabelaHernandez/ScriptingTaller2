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

	public Equip lastEquiped;

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
		set => baseAP = value;		
	}

	public int RP
	{
		get => baseRP;
		set => baseRP = value;
	}


/*public void AttackPointsCh()
	{

	} */

	public void AssociatedEquip(Equip equip)
    {
		associatedEquip = equip;

		if (slot1 == null)
        {
			slot1 = associatedEquip;
			lastEquiped = associatedEquip;

			associatedEquip.TAValue = Equip.TA.AP;
			ModifyAP(associatedEquip.EP);

        }
		else if (slot2 == null)
		{
			slot2 = associatedEquip;
			lastEquiped = associatedEquip;

			associatedEquip.TAValue = Equip.TA.RP;
			ModifyRP(associatedEquip.EP);
		}
		else if (slot3 == null)
		{
			slot3 = associatedEquip;
			lastEquiped = associatedEquip;

			associatedEquip.TAValue = Equip.TA.ALL;
			ModifyAP(associatedEquip.EP);
			ModifyRP(associatedEquip.EP);

		}
		else
        {
			fullequiped = true;
        }

	}

	public void DisassociatedEquip(Equip disassociatedEquip)
    {
		if (slot3 != null)
        {
			slot3 = null;
			lastEquiped = slot2;

			ModifyAP(-(disassociatedEquip.EP));
			ModifyRP(-(disassociatedEquip.EP));

		}
		else if (slot2 != null)
		{
			slot2 = null;
			lastEquiped = slot1;

			ModifyRP(-(disassociatedEquip.EP));
		}
		else if (slot1 != null)
		{
			slot1 = null;
			lastEquiped = null;

			ModifyAP(-(disassociatedEquip.EP));
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
