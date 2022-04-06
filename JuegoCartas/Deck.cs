using System;
using System.Collections.Generic;

public class Deck
{
	String deckName = "";

	public int chCantidad = 5;
	public int eqCantidad = 4;
	public int spCantidad = 5;

	//Contadores de cartas dentro del Maso
	public int chInsedeDeck = 0;
	public int eqInsedeDeck = 0;
	public int spInsedeDeck = 0;

	public int CPbaraja= 30;

	public List<Carta> cartas = new List<Carta>();
		
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
		int CP = aleatoriocp.Next(1, 10);

		Character character = new Character(AP, RP, CP);

	
		if (CPbaraja >= CP)
		{
			CPbaraja -= CP;
			cartas.Add(character);
			chInsedeDeck++;
		}
		
	}	

	public void CreateEquip ()
	{
		Random aleatoriocp = new Random();

		int EP = aleatoriocp.Next(1, 6);
		int CP = aleatoriocp.Next(1, 6);

		Equip equip = new Equip(EP, CP);

		if (CPbaraja >= CP )
        {
			CPbaraja -= CP;
			cartas.Add(equip);
			eqInsedeDeck++;
		}		

	}

	public void CreateSupport()
	{
		Random aleatoriocp = new Random();

		int EP = aleatoriocp.Next(1, 6);
		int CP = aleatoriocp.Next(1, 6);

		Support support = new Support(EP, CP);

		if (CPbaraja >= CP)
		{
			CPbaraja -= CP;
			cartas.Add(support);
			spInsedeDeck++;
		}
		
		
	}

	public void LlenarDeck()
    {
		//Llena la baraja con las cartas
		while(CPbaraja>0)
		{
            for (int i = 0; i < chCantidad; i++)
            {
                CreateCharacter();
            }
            for (int i = 0; i < eqCantidad; i++)
            {
                CreateEquip();
            }
            for (int i = 0; i < spCantidad; i++)
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
