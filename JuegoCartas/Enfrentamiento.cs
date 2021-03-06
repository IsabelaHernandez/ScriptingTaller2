using System;

public class Enfrentamiento
{
    public Deck jugador = new Deck();
    public Deck enemigo = new Deck();

    public Character target;

    public Enfrentamiento()
    {

    }

    public void BatallaAMuerte()
    {
        //Aquí se van a agarrar las dos barajas
        jugador.LlenarDeck();
        enemigo.LlenarDeck();

        Character actualChar = null;

        //Equip Character
        for (int i = 0; i < jugador.cartas.Count; i++)
        {

            if (jugador.cartas[i] is Character)
            {
                actualChar = (jugador.cartas[i] as Character);

            }

            if (jugador.cartas[i] is Equip)
            {
                actualChar.EquipCh(jugador.cartas[i] as Equip);
            }

        }

        for (int i = 0; i < enemigo.cartas.Count; i++)
        {
            if (enemigo.cartas[i] is Character)
            {
                actualChar = (enemigo.cartas[i] as Character);
            }

            if (enemigo.cartas[i] is Equip)
            {
                actualChar.EquipCh(enemigo.cartas[i] as Equip);
            }
        }

        //Pelea ppal
        for (int i = 0; i < jugador.cartas.Count && i < enemigo.cartas.Count; i++)
        {
            if (jugador.cartas[i] is Character && enemigo.cartas[i] is Character)
            {

                (jugador.cartas[i] as Character).AssignTarget(enemigo.cartas[i] as Character);
                (enemigo.cartas[i] as Character).AssignTarget(jugador.cartas[i] as Character);

                (jugador.cartas[i] as Character).AffinityCh(enemigo.cartas[i] as Character);

                (jugador.cartas[i] as Character).RP -= (enemigo.cartas[i] as Character).AP;
                (enemigo.cartas[i] as Character).RP -= (jugador.cartas[i] as Character).AP;

                if ((jugador.cartas[i] as Character).RP <= 0)
                {
                    jugador.cartas[i] = null;
                    jugador.ContadorDeMuertos++;
                }

                if ((enemigo.cartas[i] as Character).RP <= 0)
                {
                    enemigo.cartas[i] = null;
                    enemigo.ContadorDeMuertos++;
                }


            }
        }
        //Support Skills
        for (int i = 0; i < jugador.cartas.Count; i++)
        {

            if (jugador.cartas[i] is Character)
            {
                actualChar = (jugador.cartas[i] as Character);
                
            }

            if (jugador.cartas[i] is Support)
            {
                (jugador.cartas[i] as Support).EffectSp(actualChar);
            }

        }

        for (int i = 0; i < enemigo.cartas.Count; i++)
        {
            if (enemigo.cartas[i] is Character)
            {
                actualChar = (enemigo.cartas[i] as Character);
            }

            if (enemigo.cartas[i] is Support)
            {
                (enemigo.cartas[i] as Support).EffectSp(actualChar);
            }
        }

        //Revisión muertos
        for (int i = 0; i < jugador.cartas.Count && i < enemigo.cartas.Count; i++)
        {
            if ((jugador.cartas[i] as Character).RP <= 0)
            {
                jugador.cartas[i] = null;
                jugador.ContadorDeMuertos++;
            }

            if ((enemigo.cartas[i] as Character).RP <= 0)
            {
                enemigo.cartas[i] = null;
                enemigo.ContadorDeMuertos++;
            }
        }

    }
}
