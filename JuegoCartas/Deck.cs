using System;
using System.Collections.Generic;

public class Deck
{
	String deckName = "";
	int charcaterAmount = 0;
	int equipAmount = 0;
	int supportAmount = 0;

	int chcantidad = 5;
	int eqcantidad = 10;
	int spcantidad = 5;

	List<Carta> cartas = new List<Carta>();
		

	public Deck()
	{	
		
	}

	public void CreateCharacter()
    {
		Random aleatorioap = new Random();
		Random aleatoriorp = new Random();
		Random aleatoriocp = new Random();

		int AP = aleatorioap.Next(1, 6);
		int RP = aleatoriorp.Next(1, 6);
		int CP = aleatoriocp.Next(1, 6);

		Character character = new Character(AP, RP, CP);
		cartas.Add(character);
	}	

	public void CreateEquip ()
	{
		Random aleatoriocp = new Random();

		int CP = aleatoriocp.Next(1, 6);

		Equip equip = new Equip();
		cartas.Add(equip);

	}

	public void CreateSupport()
	{
		Random aleatoriocp = new Random();

		int CP = aleatoriocp.Next(1, 6);

		Support support = new Support();
		cartas.Add(support);
		
	}

	public void LlenarDeck()
    {
		//Llena la baraja con las cartas

		for (int i = 0; i <= chcantidad; i++)
        {
			CreateCharacter();
			
		}

		for (int i = 0; i <= eqcantidad; i++)
		{
			CreateEquip();
		}

		for (int i = 0; i <= spcantidad; i++)
		{
			CreateSupport();
		}


		/*Hacer un sistemita de slots que nos permita llenar la cantidad
		adecuanda de cartas usando los CP */


	}
	public void DestruirDeck()
    {
		//Destruye el contenido de la baraja

    }

}
