using System;

public class Deck
{
	String deckName = "";
	int charcaterAmount = 0;
	int equipAmount = 0;
	int supportAmount = 0;

	Character character = new Character();

	public Deck()
	{	
		
	}

	public void LlenarDeck()
    {
		//Llena la baraja con las cartas

		Character character = new Character();
		Support support = new Support();
		Equip equip = new Equip();

		/*Hacer un sistemita de slots que nos permita llenar la cantidad
		adecuanda de cartas usando los CP */

		character.cantidad = 5;
		support.cantidad = 5;
		equip.cantidad = 10;
	}
	public void DestruirDeck()
    {
		//Destruye el contenido de la baraja

    }

}
