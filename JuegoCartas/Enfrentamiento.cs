using System;

public class Enfrentamiento
{
    public Deck jugador = new Deck();
    public Deck enemigo = new Deck();

    public Character target;

    public Enfrentamiento()
    {
        String winner = "Aún no poseemos un ganador de este encuentro";
    }
    
    public void BatallaAMuerte()
    {
        //Aquí se van a agarrar las dos barajas

        {
            Deck deck = new Deck();
            deck.LlenarDeck();

            for (int i = 0; i < deck.cartas.Count; i++)
            {
                if(jugador.cartas[i] is Character && enemigo.cartas[i] is Character)
                {

                    //No sé si esto funcione 
                    (jugador.cartas[i] as Character).AffinityCh(target);

                    (jugador.cartas[i] as Character).RP -= (enemigo.cartas[i] as Character).AP;
                    (enemigo.cartas[i] as Character).RP -= (jugador.cartas[i] as Character).AP;

                    if ((jugador.cartas[i] as Character).RP <= 0)
                    {
                        enemigo.cartas[i] = null;
                    }

                    if ((enemigo.cartas[i] as Character).RP <= 0)
                    {
                        enemigo.cartas[i] = null;
                    }


                }
            }

        }
    }
}
