Parking p1 = new Parking();
//p1.heureArrive = 6;
//p1.heureDepart = 11;
//0 - 24

Console.WriteLine("Entrez l'heure d'arrivée : ");
p1.heureArrive = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Entrez l'heure de départ : ");
p1.heureDepart = Convert.ToInt16(Console.ReadLine());

double resultat = p1.CalculerCoutTotal(); //5h

//echo "Resultat : 10 "
Console.WriteLine("Resultat : " + resultat);


/*Parking p2 = new Parking();
double resultat = p2.CalculerCoutLongTemps(6);
Console.WriteLine("Resultat : " + resultat); // Resultat : 350*/
