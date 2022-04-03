using System;

public class Deck
{
	private Character characterCard;
	private Equip equipCard;
	private Support supportCard;

	public Deck()
	{
		String deskName = "";
		int charcaterAmount = 0;
		int equipAmount = 0;
		int supportAmount = 0;

		//Aquí va a llamar la agregación de las cartas
		characterCard = new Character();
		equipCard = new Equip();
		supportCard = new Support();

	}

	public void LlenarDeck()
    {
		//Llena la baraja con las cartas
    }
	public void DestruirDeck()
    {
		//Destruye el conido de la baraja

    }

}
