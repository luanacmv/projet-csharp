class Parking
{
    public int heureArrive; //10
    public int heureDepart; //7
    public double tarif = 2.0;

    public Parking()
    {
        //ici c'est le constructeur
    }

    public double CalculerCoutTotal()
    {
        int duree = heureDepart - heureArrive;  //3h
        return duree * tarif;
    }

    public double CalculerCoutLongTemps(int mois)
    {
        //si jusqu'à 3 mois --> 5$ rabais
        //si jusqu'à 6 mois --> 10$ rabais
        //si plus --> 15$ rabais
        double rabais = 0;

        if(mois <= 3)
        {
            rabais = 5;
        } else if (mois > 3 && mois <= 6)
        {
            rabais = 10;
        } else
        {
            rabais = 15;
        }

        //2 mois
        //tarif = 2$
        //2 mois = jours ? --> 2 * 30 = 60 jours
        // 60 * 2 = 120$ - 5$ = 115$

        //3 mois
        //tarif = 2$
        //3 mois = jours ? --> 3 * 30 = 90 jours
        // 90 * 2 = 180$ - 5$ --> 175$


        int jours = (mois * 30);
        double montant = jours * tarif;
        double montantFinalAvecRabais = montant - rabais;

        return montantFinalAvecRabais;
    }
}
