using System;

public class Desk
{
	Character character = new Character();
	String deskName = "";
	int charcaterAmount = 0;
	int equipAmount = 0;
	int supportAmount = 0;

	public Desk()
	{	

		//Aquí va a llamar la agregación de las cartas
	}

	public void LlenarDeck()
    {
		//Llena la baraja con las cartas

		Character character = new Character();
		Support support = new Support();
		Equip equip = new Equip();

		character.cantidad = 5;
		support.cantidad = 5;
		equip.cantidad = 10;
	}
	public void DestruirDeck()
    {
		//Destruye el conido de la baraja

    }

}
