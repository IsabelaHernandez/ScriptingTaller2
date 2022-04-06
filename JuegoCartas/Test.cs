using System;

public class Test
{
	 static void Main (string []args)
	{
		Deck deck = new Deck();

		deck.LlenarDeck();

        for (int i = 0; i < deck.cartas.Count; i++)
        {
			Console.WriteLine(deck.cartas[i]);
        }
	}
}
