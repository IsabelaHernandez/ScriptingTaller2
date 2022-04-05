using System;
using System.Collections.Generic;

public class Deck
{
	String deckName = "";
	int charcaterAmount = 0;
	int equipAmount = 0;
	int supportAmount = 0;

	int chCantidad = 5;
	int eqCantidad = 10;
	int spCantidad = 5;

	//Contadores de cartas dentro del Maso
	public int chInsedeDeck = 0;
	public int eqInsedeDeck = 0;
	public int spIndideDeck = 0;

	int CPbaraja= 30;

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
		int CP = aleatoriocp.Next(1, 11);

		Character character = new Character(AP, RP, CP);

		CPbaraja -= CP;

		if (CPbaraja <= CP)
		{
			cartas.Add(character);
			chInsedeDeck++;
		}
		
	}	

	public void CreateEquip ()
	{
		Random aleatoriocp = new Random();

		int EP = aleatoriocp.Next(1, 6);
		int CP = aleatoriocp.Next(1, 11);

		Equip equip = new Equip(EP, CP);

		CPbaraja -= CP;

		if (CPbaraja <= CP )
        {
			cartas.Add(equip);
			eqInsedeDeck++;
		}		

	}

	public void CreateSupport()
	{
		Random aleatoriocp = new Random();

		int EP = aleatoriocp.Next(1, 6);
		int CP = aleatoriocp.Next(1, 11);

		Support support = new Support(EP, CP);

		CPbaraja -= CP;

		if (CPbaraja <= CP)
		{
			cartas.Add(support);
			spIndideDeck++;
		}
		
		
	}

	public void LlenarDeck()
    {
		//Llena la baraja con las cartas

		while (CPbaraja < 0)
		{
			//En caso de tener problemas, usar los contadores de cartas aquí
			for (int i = 0; i <= chCantidad; i++)
			{
				CreateCharacter();
			}

			for (int i = 0; i <= eqCantidad; i++)
			{
				CreateEquip();
			}

			for (int i = 0; i <= spCantidad; i++)
			{
				CreateSupport();
			}

		}		

	}
	public void DestruirDeck()
    {
		//Destruye el contenido de la baraja

    }

}
