namespace YatzyNewTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLER

            //Spiller
            int antalSpiller = 0;
            string spiller1 = "";
            string spiller2 = "";
            string spiller3 = "";
            string spiller4 = "";

            //Terninger

            int terning1, terning2, terning3, terning4, terning5;

            int antalRunder = 14;
            //Total point/score for de forskellige spiller
            int sumSpiller1 = 0;
            int sumSpiller2 = 0;
            int sumSpiller3 = 0;
            int sumSpiller4 = 0;
            //kombinationsValg, hvis der er blevet svaret nej
            string kombinationsValg = "";
            string svar = "";
            string svar1 = "";
            //Pointtype
            int a, b, c, d, e, f, g, h, i, j, k, l, m, n = 0;
            int a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1, n1 = 0;

            //Velkomst
            Console.WriteLine("Welcome to YATZY");
            Console.WriteLine();
            Console.WriteLine();
            //Bede om at brugeren bekræfter, at brugeren vil spille spillet
            Console.Write("Vil du starte spillet, ja / nej ?");
            string startSpil = Console.ReadLine();
            Console.WriteLine();

            switch (startSpil)
            {

                case "ja":
                    Console.WriteLine("Angiv antal spiller ved at skrive et tal (Min 2 og Max 4 spiller):");
                    antalSpiller = int.Parse(Console.ReadLine());
                    break;

                case "nej":
                    Console.WriteLine("Tak for denne gang.");
                    break;
                default:
                    Console.WriteLine("Du har tastet forkert. Prøv igen");
                    //Bede om at brugeren bekræfter, at brugeren vil spille spillet
                    Console.Write("Vil du starte spillet, ja / nej ?");
                    startSpil = Console.ReadLine();
                    Console.WriteLine();
                    break;
            }

            //Valg af, hvor mange spiller der skal spille spillet
            switch (antalSpiller)
            {

                case 2:
                    Console.WriteLine();
                    Console.Write("Spiller 1 hedder:");
                    spiller1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Spiller 2 hedder:");
                    spiller2 = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.Write("Spiller 1 hedder:");
                    spiller1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Spiller 2 hedder:");
                    spiller2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Spiller 3 hedder:");
                    spiller3 = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.Write("Spiller 1 hedder:");
                    spiller1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Spiller 2 hedder:");
                    spiller2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Spiller 3 hedder:");
                    spiller3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Spiller 4 hedder:");
                    spiller4 = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Du har tastet forkert. Prøv igen");


                    Console.WriteLine();
                    Console.WriteLine("Angiv antal spiller ved at skrive et tal (Min 2 og Max 4 spiller):");
                    antalSpiller = int.Parse(Console.ReadLine());
                    break;
            }


            //Spiller 1 kaster 5 terninger f´rste gang
            //metode til at få et tilfældigt heltal, der er inden for et specificeret interval
            Console.WriteLine();
            Console.WriteLine();
            //Hvilke terningeøjne har vi fået

            Console.WriteLine($"{spiller1}, du har kastet følgende:");

            Console.WriteLine();
            Console.WriteLine();

            // Opretter et nyt Random-objekt med navnet random, som vi vil bruge til at generere tilfældige tal.
            Random random = new Random();

            // Opretter et nyt heltalsarray med navnet terninger, som vil indeholde værdierne for vores terninger.
            // Arrayet har en længde på 5, da vi har 5 terninger.
            int[] terninger = new int[5];

            // Starter en løkke, der kører fra 0 til længden af terninger-arrayet minus 1. Dette sikrer, at vi gennemgår hvert element i arrayet.
            for (int q = 0; q < terninger.Length; q++)
            {
                // Tilføjer et tilfældigt tal mellem 1 og 6 til terning array (inklusive 1 og eksklusive 7) 
                terninger[q] = random.Next(1, 7);


                // Udskriver værdien af det aktuelle element i terninger-arrayet.
                // første {q + 1} bliver 1 (position), fordi q er 0,print af det genererede øjnetal laves af {terninger[q]}
                Console.WriteLine($"Terning {q + 1}: {terninger[q]}");
            }





            // Jeg beder spiller 1 om at vælge om nogle terninger skal kastes om
            Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
            svar = Console.ReadLine();

            switch (svar)
            {
                case "ja":
                    // Bede om brugerinput
                    Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma): ");
                    // Brugerinput, f.eks. "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5. Teksten gemmes som en streng.
                    string valg = Console.ReadLine();

                    // Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
                    // Strengdele som er numre bliver gemt som separate strenge i et array kaldet "valgteTerninger".
                    string[] valgteTerninger = valg.Split(',');

                    // Opretter et nyt heltalsarray til at gemme de nye kast
                    int[] minArray3 = new int[5];

                    // Gennemgang af hvert streng i arrayen, kast om på de valgte terninger
                    foreach (string tal in valgteTerninger)
                    {
                        // Strengen bliver konverteret til et heltal, og vi trækker 1 fra for at komme til det korrekte indeks, som brugeren ønsker at kaste om på
                        int terningIndex = int.Parse(tal) - 1;

                        // Det valgte terningsindex i minArray3 bliver kastet om, dvs. den valgte terning(er) bliver kastet om
                        minArray3[terningIndex] = new Random().Next(1, 7);
                    }

                    // Vis resultatet af de nye kast
                    Console.WriteLine("Nyt resultat:");
                    // Start med indeks 0 og gå frem til minArray3's længde (alle tal), forøg i med 1 efter hvert kodecyklus
                    for (int p = 0; p < minArray3.Length; p++)
                    {
                        // Teksten "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
                        Console.WriteLine($"Terning {p + 1} = {minArray3[p]}");
                    }

                    // Spørg brugeren om de vil kaste om på nogle af deres terninger igen
                    Console.Write("Vil du kaste om på nogle af dine terninger? (Skriv 'ja' eller 'nej'): ");
                    svar1 = Console.ReadLine();
                    break;

                case "nej":
                    // Udskriv valgmulighederne for kombinationer
                    Console.WriteLine();
                    Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
                    Console.WriteLine();
                    Console.WriteLine("1’ere: Summen af alle terninger med 1. Skriv a:");
                    Console.WriteLine("2’ere: Summen af alle terninger med 2. Skriv b:");
                    Console.WriteLine("3’ere: Summen af alle terninger med 3. Skriv c:");
                    Console.WriteLine("4’ere: Summen af alle terninger med 4. Skriv d:");
                    Console.WriteLine("5’ere: Summen af alle terninger med 5. Skriv e:");
                    Console.WriteLine("6’ere: Summen af alle terninger med 6. Skriv f:");
                    Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
                    Console.WriteLine("To par: To forskellige par. Skriv h:");
                    Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
                    Console.WriteLine("Fire ens: Fire terninger med samme værdi. Skriv j:");
                    Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point. Skriv k:");
                    Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point. Skriv l:");
                    Console.WriteLine("Chancen: Summen af alle fem terninger. Skriv m:");
                    Console.WriteLine("Yatzy: Fem terninger med samme værdi. Skriv n:");
                    Console.WriteLine();
                    Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
                    Console.WriteLine();
                    Console.Write("Hvilken kombination vil du vælge (a, b, c, d, e, f, g, h, i, j, k, l, m, n)? ");
                    kombinationsValg = Console.ReadLine();
                    break;
            }

            // Opretter et nyt heltalsarray til at gemme de nye kast
            int[] minArray5 = new int[5];
            //oprettelse af et objekt
            Random r = new Random();

            switch (svar1)
            {
                case "ja":
                    // Bede om brugerinput
                    Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma): ");
                    // Brugerinput, f.eks. "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5. Teksten gemmes som en streng.
                    string valg = Console.ReadLine();

                    // Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
                    // Strengdele som er numre bliver gemt som separate strenge i et array kaldet "valgteTerninger".
                    string[] valgteTerninger = valg.Split(',');



                    // Gennemgang af hvert streng i arrayen, kast om på de valgte terninger
                    foreach (string tal in valgteTerninger)
                    {
                        // Streng bliver konverteret til int, og vi trækker 1 fra for at komme til det korrekte indeks, det terningeindex, som brugeren ønsker at kaste om
                        int terningIndex = int.Parse(tal) - 1;

                        // Det valgte terningsindex i minArray5 bliver kastet om, dvs. den valgte terning(er) bliver kastet om
                        (new int[5])[terningIndex] = r.Next(1, 7);
                    }

                    // Vis resultatet af de nye kast
                    Console.WriteLine("Nyt resultat:");
                    // Start med index 0 og gå frem til minArray5's længde (alle tal), forøg i med 1 efter hvert kodecyklus
                    for (int ø = 0; ø < (new int[5]).Length; ø++)
                    {
                        // Tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
                        Console.WriteLine($"Terning {ø + 1} = {(new int[5])[ø]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
                    Console.WriteLine();
                    Console.WriteLine("1’ere: Summen af alle terninger med 1. Skriv a:");
                    Console.WriteLine("2’ere: Summen af alle terninger med 2. Skriv b:");
                    Console.WriteLine("3’ere: Summen af alle terninger med 3. Skriv c:");
                    Console.WriteLine("4’ere: Summen af alle terninger med 4. Skriv d:");
                    Console.WriteLine("5’ere: Summen af alle terninger med 5. Skriv e:");
                    Console.WriteLine("6’ere: Summen af alle terninger med 6. Skriv f:");
                    Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
                    Console.WriteLine("To par: To forskellige par. Skriv h:");
                    Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
                    Console.WriteLine("Fire ens: Fire terninger med samme værdi. Skriv j:");
                    Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point. Skriv k:");
                    Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point. Skriv l:");
                    Console.WriteLine("Chancen: Summen af alle fem terninger. Skriv m:");
                    Console.WriteLine("Yatzy: Fem terninger med samme værdi. Skriv n:");
                    Console.WriteLine();
                    Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
                    Console.WriteLine();
                    Console.Write("Hvilken kombination vil du vælge (a, b, c, d, e, f, g, h, i, j, k, l, m, n)? ");
                    kombinationsValg = Console.ReadLine();
                    break;

                case "nej":
                    // Udskriv valgmulighederne for kombinationer
                    Console.WriteLine();
                    Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
                    Console.WriteLine();
                    Console.WriteLine("1’ere: Summen af alle terninger med 1. Skriv a:");
                    Console.WriteLine("2’ere: Summen af alle terninger med 2. Skriv b:");
                    Console.WriteLine("3’ere: Summen af alle terninger med 3. Skriv c:");
                    Console.WriteLine("4’ere: Summen af alle terninger med 4. Skriv d:");
                    Console.WriteLine("5’ere: Summen af alle terninger med 5. Skriv e:");
                    Console.WriteLine("6’ere: Summen af alle terninger med 6. Skriv f:");
                    Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
                    Console.WriteLine("To par: To forskellige par. Skriv h:");
                    Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
                    Console.WriteLine("Fire ens: Fire terninger med samme værdi. Skriv j:");
                    Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point. Skriv k:");
                    Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point. Skriv l:");
                    Console.WriteLine("Chancen: Summen af alle fem terninger. Skriv m:");
                    Console.WriteLine("Yatzy: Fem terninger med samme værdi. Skriv n:");
                    Console.WriteLine();
                    Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
                    Console.WriteLine();
                    Console.Write("Hvilken kombination vil du vælge (a, b, c, d, e, f, g, h, i, j, k, l, m, n)? ");
                    kombinationsValg = Console.ReadLine();
                    break;
            }




            switch (kombinationsValg)

            {

                case "a":

                    Console.WriteLine($"Din resultat er: {a}");
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "b":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "c":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "d":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "e":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "f":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "g":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "h":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "i":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "j":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "k":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "l":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "m":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "n":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;

            }
            //Spiller 2 kaster 5 terninger f´rste gang
            //metode til at få et tilfældigt heltal, der er inden for et specificeret interval
            Console.WriteLine();
            Console.WriteLine();
            //Hvilke terningeøjne har vi fået

            Console.WriteLine($"{spiller1}, du har kastet følgende:");

            Console.WriteLine();
            Console.WriteLine();

            Random r = new Random();
            terning1 = r.Next(1, 6);
            terning2 = r.Next(1, 6);
            terning3 = r.Next(1, 6);
            terning4 = r.Next(1, 6);
            terning5 = r.Next(1, 6);

            Console.WriteLine("Terning 1 = " + terning1);
            Console.WriteLine("Terning 2 = " + terning2);
            Console.WriteLine("Terning 2 = " + terning3);
            Console.WriteLine("Terning 2 = " + terning4);
            Console.WriteLine("Terning 2 = " + terning5);

            //jeg opretter en array, som bruges til at gemme terningekast
            int[] minArray1 = new int[] { terning1, terning2, terning3, terning4, terning5 };

            // Jeg beder spiller 1 om at vælge om nogle terninger skal kastes om
            Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
            svar = Console.ReadLine();

            switch (svar)
            {

                case "ja":
                    //Bede om brugerindput
                    Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma)");
                    //brugerindput, skrive for eksempel "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5.. Teksten gemmes som string.
                    string valg = Console.ReadLine();

                    //Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
                    //Stregdele som er numre blevet gemt som separate strenge i et array kaldet "valgteTerninger".
                    string[] valgteTerninger = valg.Split(',');

                    // Gennemgang af hvert streng i arrayen, Kast om på de valgte terninger
                    foreach (string tal in valgteTerninger)
                    {
                        //streng bliver konverteret til int, og vi skriver  minus -1 for at komme til korrekt indeks, det terningeindex, som brugeren ønsker at kaste om
                        int terningIndex = int.Parse(tal) - 1;

                        //det valgte terningsindex i minArray1 bliver kastet om for eksempel, den valgte terning(er)  bliver kastet om
                        minArray1[terningIndex] = r.Next(1, 7);
                    }

                    // Vis resultatet af de nye kast
                    Console.Write("Nyt resultat:");
                    //start med index 0 og gå frem til minArray længde (alle tal), forhøj i med 1 efter hvert kodecyklus
                    for (int z = 0; z < minArray1.Length; z++)
                    {
                        //tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
                        Console.WriteLine($"Terning {z + 1} = {minArray1[z]}");
                    }

                    // Jeg beder spiller 1 om at vælge en sidste gang om nogle terninger skal kastes om
                    Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
                    string svar8 = Console.ReadLine();
                    break;


                case "nej":
                    Console.WriteLine();
                    Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
                    Console.WriteLine();
                    Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
                    Console.WriteLine();
                    Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
                    Console.WriteLine();
                    Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
                    Console.WriteLine();
                    Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
                    Console.WriteLine();
                    Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
                    Console.WriteLine();
                    Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
                    Console.WriteLine();
                    Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
                    Console.WriteLine();
                    Console.WriteLine("To par: To forskellige par.Skriv h:");
                    Console.WriteLine();
                    Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
                    Console.WriteLine();
                    Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
                    Console.WriteLine();
                    Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
                    Console.WriteLine();
                    Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
                    Console.WriteLine();
                    Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
                    Console.WriteLine();
                    Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
                    Console.WriteLine();
                    Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
                    Console.WriteLine();
                    Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
                    kombinationsValg = Console.ReadLine();
                    break;
            }


            switch (svar8)
            {

                case "ja":
                    //Bede om brugerindput
                    Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma)");
                    //brugerindput, skrive for eksempel "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5.. Teksten gemmes som string.
                    string valg = Console.ReadLine();

                    //Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
                    //Stregdele som er numre blevet gemt som separate strenge i et array kaldet "valgteTerninger".
                    string[] valgteTerninger = valg.Split(',');

                    // Gennemgang af hvert streng i arrayen, Kast om på de valgte terninger
                    foreach (string tal in valgteTerninger)
                    {
                        //streng bliver konverteret til int, og vi skriver  minus -1 for at komme til korrekt indeks, det terningeindex, som brugeren ønsker at kaste om
                        int terningIndex = int.Parse(tal) - 1;

                        //det valgte terningsindex i minArray1 bliver kastet om for eksempel, den valgte terning(er)  bliver kastet om
                        minArray1[terningIndex] = r.Next(1, 7);
                    }

                    // Vis resultatet af de nye kast
                    Console.Write("Nyt resultat:");
                    //start med index 0 og gå frem til minArray længde (alle tal), forhøj i med 1 efter hvert kodecyklus
                    for (int z = 0; z < minArray1.Length; z++)
                    {
                        //tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
                        Console.WriteLine($"Terning {z + 1} = {minArray1[z]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
                    Console.WriteLine();
                    Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
                    Console.WriteLine();
                    Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
                    Console.WriteLine();
                    Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
                    Console.WriteLine();
                    Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
                    Console.WriteLine();
                    Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
                    Console.WriteLine();
                    Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
                    Console.WriteLine();
                    Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
                    Console.WriteLine();
                    Console.WriteLine("To par: To forskellige par.Skriv h:");
                    Console.WriteLine();
                    Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
                    Console.WriteLine();
                    Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
                    Console.WriteLine();
                    Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
                    Console.WriteLine();
                    Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
                    Console.WriteLine();
                    Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
                    Console.WriteLine();
                    Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
                    Console.WriteLine();
                    Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
                    Console.WriteLine();
                    Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
                    kombinationsValg = Console.ReadLine();
                    break;


                case "nej":
                    Console.WriteLine();
                    Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
                    Console.WriteLine();
                    Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
                    Console.WriteLine();
                    Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
                    Console.WriteLine();
                    Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
                    Console.WriteLine();
                    Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
                    Console.WriteLine();
                    Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
                    Console.WriteLine();
                    Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
                    Console.WriteLine();
                    Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
                    Console.WriteLine();
                    Console.WriteLine("To par: To forskellige par.Skriv h:");
                    Console.WriteLine();
                    Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
                    Console.WriteLine();
                    Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
                    Console.WriteLine();
                    Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
                    Console.WriteLine();
                    Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
                    Console.WriteLine();
                    Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
                    Console.WriteLine();
                    Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
                    Console.WriteLine();
                    Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
                    Console.WriteLine();
                    Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
                    kombinationsValg = Console.ReadLine();
                    break;
            }

            switch (kombinationsValg)

            {

                case "a":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "b":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "c":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "d":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "e":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "f":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "g":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "h":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                case "i":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "j":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "k":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "l":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "m":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;
                case "n":
                    Console.WriteLine("Din resultat er: {0}", a);
                    Console.WriteLine();
                    //Scoreboard for antalSpiller
                    Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
                    Console.WriteLine();
                    Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a1);
                    Console.WriteLine();
                    Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b1);
                    Console.WriteLine();
                    Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c1);
                    Console.WriteLine();
                    Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d1);
                    Console.WriteLine();
                    Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e1);
                    Console.WriteLine();
                    Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f1);
                    Console.WriteLine();
                    Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g1);
                    Console.WriteLine();
                    Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h1);
                    Console.WriteLine();
                    Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i1);
                    Console.WriteLine();
                    Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j1);
                    Console.WriteLine();
                    Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k1);
                    Console.WriteLine();
                    Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l1);
                    Console.WriteLine();
                    Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m1);
                    Console.WriteLine();
                    Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n1);
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;

            }

            ////if (antalSpiller == 3) 
            ////{ 
            //////Spiller 3 kaster 5 terninger f´rste gang
            //////metode til at få et tilfældigt heltal, der er inden for et specificeret interval
            ////Console.WriteLine();
            ////Console.WriteLine();
            //////Hvilke terningeøjne har vi fået

            ////Console.WriteLine($"{spiller1}, du har kastet følgende:");

            ////Console.WriteLine();
            ////Console.WriteLine();

            ////Random r = new Random();
            ////terning1 = r.Next(1, 6);
            ////terning2 = r.Next(1, 6);
            ////terning3 = r.Next(1, 6);
            ////terning4 = r.Next(1, 6);
            ////terning5 = r.Next(1, 6);

            ////Console.WriteLine("Terning 1 = " + terning1);
            ////Console.WriteLine("Terning 2 = " + terning2);
            ////Console.WriteLine("Terning 2 = " + terning3);
            ////Console.WriteLine("Terning 2 = " + terning4);
            ////Console.WriteLine("Terning 2 = " + terning5);

            //////jeg opretter en array, som bruges til at gemme terningekast
            ////int[] minArray1 = new int[] { terning1, terning2, terning3, terning4, terning5 };

            ////// Jeg beder spiller 1 om at vælge om nogle terninger skal kastes om
            ////Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
            ////string svar = Console.ReadLine();

            ////switch (svar)
            ////{

            ////    case "ja":
            ////        //Bede om brugerindput
            ////        Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma)");
            ////        //brugerindput, skrive for eksempel "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5.. Teksten gemmes som string.
            ////        string valg = Console.ReadLine();

            ////        //Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
            ////        //Stregdele som er numre blevet gemt som separate strenge i et array kaldet "valgteTerninger".
            ////        string[] valgteTerninger = valg.Split(',');

            ////        // Gennemgang af hvert streng i arrayen, Kast om på de valgte terninger
            ////        foreach (string tal in valgteTerninger)
            ////        {
            ////            //streng bliver konverteret til int, og vi skriver  minus -1 for at komme til korrekt indeks, det terningeindex, som brugeren ønsker at kaste om
            ////            int terningIndex = int.Parse(tal) - 1;

            ////            //det valgte terningsindex i minArray1 bliver kastet om for eksempel, den valgte terning(er)  bliver kastet om
            ////            minArray1[terningIndex] = r.Next(1, 7);
            ////        }

            ////        // Vis resultatet af de nye kast
            ////        Console.Write("Nyt resultat:");
            ////        //start med index 0 og gå frem til minArray længde (alle tal), forhøj i med 1 efter hvert kodecyklus
            ////        for (int i = 0; i < minArray1.Length; i++)
            ////        {
            ////            //tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
            ////            Console.WriteLine($"Terning {i + 1} = {minArray1[i]}");
            ////        }

            ////        // Jeg beder spiller 1 om at vælge en sidste gang om nogle terninger skal kastes om
            ////        Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
            ////        string svar1 = Console.ReadLine();
            ////        break;


            ////    case "nej":
            ////        Console.WriteLine();
            ////        Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par: To forskellige par.Skriv h:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
            ////        Console.WriteLine();
            ////        Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
            ////        kombinationsValg = Console.ReadLine();
            ////        break;
            ////}


            ////switch (svar1)
            ////{

            ////    case "ja":
            ////        //Bede om brugerindput
            ////        Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma)");
            ////        //brugerindput, skrive for eksempel "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5.. Teksten gemmes som string.
            ////        string valg = Console.ReadLine();

            ////        //Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
            ////        //Stregdele som er numre blevet gemt som separate strenge i et array kaldet "valgteTerninger".
            ////        string[] valgteTerninger = valg.Split(',');

            ////        // Gennemgang af hvert streng i arrayen, Kast om på de valgte terninger
            ////        foreach (string tal in valgteTerninger)
            ////        {
            ////            //streng bliver konverteret til int, og vi skriver  minus -1 for at komme til korrekt indeks, det terningeindex, som brugeren ønsker at kaste om
            ////            int terningIndex = int.Parse(tal) - 1;

            ////            //det valgte terningsindex i minArray1 bliver kastet om for eksempel, den valgte terning(er)  bliver kastet om
            ////            minArray1[terningIndex] = r.Next(1, 7);
            ////        }

            ////        // Vis resultatet af de nye kast
            ////        Console.Write("Nyt resultat:");
            ////        //start med index 0 og gå frem til minArray længde (alle tal), forhøj i med 1 efter hvert kodecyklus
            ////        for (int i = 0; i < minArray1.Length; i++)
            ////        {
            ////            //tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
            ////            Console.WriteLine($"Terning {i + 1} = {minArray1[i]}");
            ////        }
            ////        Console.WriteLine();
            ////        Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par: To forskellige par.Skriv h:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
            ////        Console.WriteLine();
            ////        Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
            ////        kombinationsValg = Console.ReadLine();
            ////        break;


            ////    case "nej":
            ////        Console.WriteLine();
            ////        Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par: To forskellige par.Skriv h:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
            ////        Console.WriteLine();
            ////        Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
            ////        kombinationsValg = Console.ReadLine();
            ////        break;
            ////}

            ////switch (kombinationsValg)

            ////{

            ////    case "a":

            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "b":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "c":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "d":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "e":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "f":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "g":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "h":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "i":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "j":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "k":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "l":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "m":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "n":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    default:
            ////        Console.WriteLine("Ugyldigt valg. Prøv igen.");
            ////        break;

            ////}
            ////}
            ////if (antalSpiller==4)
            ////{ 
            //////Spiller 4 kaster 5 terninger f´rste gang
            //////metode til at få et tilfældigt heltal, der er inden for et specificeret interval
            ////Console.WriteLine();
            ////Console.WriteLine();
            //////Hvilke terningeøjne har vi fået

            ////Console.WriteLine($"{spiller1}, du har kastet følgende:");

            ////Console.WriteLine();
            ////Console.WriteLine();

            ////Random r = new Random();
            ////terning1 = r.Next(1, 6);
            ////terning2 = r.Next(1, 6);
            ////terning3 = r.Next(1, 6);
            ////terning4 = r.Next(1, 6);
            ////terning5 = r.Next(1, 6);

            ////Console.WriteLine("Terning 1 = " + terning1);
            ////Console.WriteLine("Terning 2 = " + terning2);
            ////Console.WriteLine("Terning 2 = " + terning3);
            ////Console.WriteLine("Terning 2 = " + terning4);
            ////Console.WriteLine("Terning 2 = " + terning5);

            //////jeg opretter en array, som bruges til at gemme terningekast
            ////int[] minArray1 = new int[] { terning1, terning2, terning3, terning4, terning5 };

            ////// Jeg beder spiller 1 om at vælge om nogle terninger skal kastes om
            ////Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
            ////string svar = Console.ReadLine();

            ////switch (svar)
            ////{

            ////    case "ja":
            ////        //Bede om brugerindput
            ////        Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma)");
            ////        //brugerindput, skrive for eksempel "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5.. Teksten gemmes som string.
            ////        string valg = Console.ReadLine();

            ////        //Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
            ////        //Stregdele som er numre blevet gemt som separate strenge i et array kaldet "valgteTerninger".
            ////        string[] valgteTerninger = valg.Split(',');

            ////        // Gennemgang af hvert streng i arrayen, Kast om på de valgte terninger
            ////        foreach (string tal in valgteTerninger)
            ////        {
            ////            //streng bliver konverteret til int, og vi skriver  minus -1 for at komme til korrekt indeks, det terningeindex, som brugeren ønsker at kaste om
            ////            int terningIndex = int.Parse(tal) - 1;

            ////            //det valgte terningsindex i minArray1 bliver kastet om for eksempel, den valgte terning(er)  bliver kastet om
            ////            minArray1[terningIndex] = r.Next(1, 7);
            ////        }

            ////        // Vis resultatet af de nye kast
            ////        Console.Write("Nyt resultat:");
            ////        //start med index 0 og gå frem til minArray længde (alle tal), forhøj i med 1 efter hvert kodecyklus
            ////        for (int i = 0; i < minArray1.Length; i++)
            ////        {
            ////            //tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
            ////            Console.WriteLine($"Terning {i + 1} = {minArray1[i]}");
            ////        }

            ////        // Jeg beder spiller 1 om at vælge en sidste gang om nogle terninger skal kastes om
            ////        Console.Write("Vil du kaste om på nogle af dine terningerne? (Skriv 'ja' eller 'nej')");
            ////        string svar1 = Console.ReadLine();
            ////        break;


            ////    case "nej":
            ////        Console.WriteLine();
            ////        Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par: To forskellige par.Skriv h:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
            ////        Console.WriteLine();
            ////        Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
            ////        kombinationsValg = Console.ReadLine();
            ////        break;
            ////}


            ////switch (svar1)
            ////{

            ////    case "ja":
            ////        //Bede om brugerindput
            ////        Console.Write("Skriv hvilke terninger du vil kaste om (1-5, adskilt med komma)");
            ////        //brugerindput, skrive for eksempel "1,3,5", hvilket betyder, at de vil kaste om på terning nummer 1, 3 og 5.. Teksten gemmes som string.
            ////        string valg = Console.ReadLine();

            ////        //Strengen "valg" bliver delt op ved kommaer ved hjælp af metoden Split(','), hvilket betyder, at den opdeles i separate dele hver gang der er et komma.
            ////        //Stregdele som er numre blevet gemt som separate strenge i et array kaldet "valgteTerninger".
            ////        string[] valgteTerninger = valg.Split(',');

            ////        // Gennemgang af hvert streng i arrayen, Kast om på de valgte terninger
            ////        foreach (string tal in valgteTerninger)
            ////        {
            ////            //streng bliver konverteret til int, og vi skriver  minus -1 for at komme til korrekt indeks, det terningeindex, som brugeren ønsker at kaste om
            ////            int terningIndex = int.Parse(tal) - 1;

            ////            //det valgte terningsindex i minArray1 bliver kastet om for eksempel, den valgte terning(er)  bliver kastet om
            ////            minArray1[terningIndex] = r.Next(1, 7);
            ////        }

            ////        // Vis resultatet af de nye kast
            ////        Console.Write("Nyt resultat:");
            ////        //start med index 0 og gå frem til minArray længde (alle tal), forhøj i med 1 efter hvert kodecyklus
            ////        for (int i = 0; i < minArray1.Length; i++)
            ////        {
            ////            //tekst "Terning" nummer printes ud, ved at vi går fra indeks til antal øjne på terningen
            ////            Console.WriteLine($"Terning {i + 1} = {minArray1[i]}");
            ////        }
            ////        Console.WriteLine();
            ////        Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par: To forskellige par.Skriv h:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
            ////        Console.WriteLine();
            ////        Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
            ////        kombinationsValg = Console.ReadLine();
            ////        break;


            ////    case "nej":
            ////        Console.WriteLine();
            ////        Console.WriteLine("Du kan vælge en af disse kombinationer for at udregne din score:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere: Summen af alle terninger med 1.Skriv a:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere: Summen af alle terninger med 2.Skriv b:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere: Summen af alle terninger med 3.Skriv c:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere: Summen af alle terninger med 4.Skriv d:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere: Summen af alle terninger med 5.Skriv e:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere: Summen af alle terninger med 6.Skriv f:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par: To terninger med samme værdi. Skriv g:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par: To forskellige par.Skriv h:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens: Tre terninger med samme værdi. Skriv i:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens: Fire terninger med samme værdi.Skriv j:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight: Fem terninger i rækkefølge fra 1 til 5. 15 point.Skriv k:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight: Fem terninger i rækkefølge fra 2 til 6. 20 point.Skriv l:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen: Summen af alle fem terninger.Skriv m:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy: Fem terninger med samme værdi.Skriv n:");
            ////        Console.WriteLine();
            ////        Console.WriteLine("HUSK DU KAN KUN VÆLGE EN KOMBINATION 1 GANG I LØBET AF SPILLET");
            ////        Console.WriteLine();
            ////        Console.Write("Hvilken kombination vil du vælge(a,b,c,d,e,f,g,h,k,l,m)?");
            ////        kombinationsValg = Console.ReadLine();
            ////        break;
            ////}

            ////switch (kombinationsValg)

            ////{

            ////    case "a":

            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "b":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "c":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "d":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "e":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "f":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "g":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "h":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    case "i":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "j":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "k":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "l":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "m":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;
            ////    case "n":
            ////        Console.WriteLine("Din resultat er: {0}", a);
            ////        Console.WriteLine();
            ////        //Scoreboard for antalSpiller
            ////        Console.WriteLine("Scoreboard for {0} spiller:", antalSpiller);
            ////        Console.WriteLine();
            ////        Console.WriteLine("1’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, a, spiller2, a);
            ////        Console.WriteLine();
            ////        Console.WriteLine("2’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, b, spiller2, b);
            ////        Console.WriteLine();
            ////        Console.WriteLine("3’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, c, spiller2, c);
            ////        Console.WriteLine();
            ////        Console.WriteLine("4’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, d, spiller2, d);
            ////        Console.WriteLine();
            ////        Console.WriteLine("5’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, e, spiller2, e);
            ////        Console.WriteLine();
            ////        Console.WriteLine("6’ere resultater:{0} har {1} point, {2} har {3} point ", spiller1, f, spiller2, f);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Et par´resultater:{0} har {1} point, {2} har {3} point ", spiller1, g, spiller2, g);
            ////        Console.WriteLine();
            ////        Console.WriteLine("To par resultater:{0} har {1} point, {2} har {3} point ", spiller1, h, spiller2, h);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Tre ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, i, spiller2, i);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Fire ens resultater:{0} har {1} point, {2} har {3} point ", spiller1, j, spiller2, j);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Lille straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, k, spiller2, k);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Store straight resultater:{0} har {1} point, {2} har {3} point ", spiller1, l, spiller2, l);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Chancen resultater:{0} har {1} point, {2} har {3} point ", spiller1, m, spiller2, m);
            ////        Console.WriteLine();
            ////        Console.WriteLine("Yatzy resultater:{0} har {1} point, {2} har {3} point ", spiller1, n, spiller2, n);
            ////        break;

            ////    default:
            ////        Console.WriteLine("Ugyldigt valg. Prøv igen.");
            ////        break;

            ////}

            ////}


            //Udregning af scoremuligheder

            //Spiller 1
            //Enere


            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 1
            foreach (int øjne in minArray1)
            {
                if (øjne == 1)
                {
                    // Hvis øjne er 1, så læg det til summen af enere
                    // Vi lægger værdien af variablen øjne til værdien af variablen a og gemmer resultatet tilbage i a. a+=øjne er det samme som a=a+øjne
                    a = a + øjne;
                }
            }

            //Toere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 2
            foreach (int øjne in minArray1)
            {
                if (øjne == 2)
                {
                    // Hvis øjne er 2, så læg det til summen af toere
                    b += øjne;
                }
            }
            //Trere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 3
            foreach (int øjne in minArray1)
            {
                if (øjne == 3)
                {
                    // Hvis øjne er 3, så læg det til summen af trere
                    c += øjne;
                }
            }
            //Fire

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 4
            foreach (int øjne in minArray1)
            {
                if (øjne == 4)
                {
                    // Hvis øjne er 4, så læg det til summen af fire
                    d += øjne;
                }
            }
            //Femere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 5
            foreach (int øjne in minArray1)
            {
                if (øjne == 5)
                {
                    // Hvis øjne er 1, så læg det til summen af femere
                    e += øjne;
                }
            }
            //Seksere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 6
            foreach (int øjne in minArray1)
            {
                if (øjne == 6)
                {
                    // Hvis øjne er 1, så læg det til summen af seksere
                    f += øjne;
                }
            }

            //Et par

            foreach (int øjne in minArray1)
            {
                if (øjne == 1 && øjne == 1 || øjne == 2 && øjne == 2 || øjne == 3 && øjne == 3 || øjne == 4 && øjne == 4 || øjne == 5 && øjne == 5 || øjne == 6 && øjne == 6)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    g = 50;
            }

            //To par

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    h = 50;
            }

            //Tre ens:MANGLER

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    i = 50;
            }
            //Fire ens

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    j = 50;
            }
            //Lille Straight
            k = 0;
            //Store Straight
            l = 0;
            //chancen er summen af alle 5 terninger
            m = (terning1 + terning2 + terning3 + terning4 + terning5);
            //Yatzy 50 point

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    n = 50;
            }


            //Spiller 2
            //Enere


            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 1
            foreach (int øjne in minArray1)
            {
                if (øjne == 1)
                {
                    // Hvis øjne er 1, så læg det til summen af enere
                    // Vi lægger værdien af variablen øjne til værdien af variablen a og gemmer resultatet tilbage i a. a+=øjne er det samme som a=a+øjne
                    a1 = a1 + øjne;
                }
            }

            //Toere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 2
            foreach (int øjne in minArray1)
            {
                if (øjne == 2)
                {
                    // Hvis øjne er 2, så læg det til summen af toere
                    b1 += øjne;
                }
            }
            //Trere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 3
            foreach (int øjne in minArray1)
            {
                if (øjne == 3)
                {
                    // Hvis øjne er 3, så læg det til summen af trere
                    c1 += øjne;
                }
            }
            //Fire

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 4
            foreach (int øjne in minArray1)
            {
                if (øjne == 4)
                {
                    // Hvis øjne er 4, så læg det til summen af fire
                    d1 += øjne;
                }
            }
            //Femere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 5
            foreach (int øjne in minArray1)
            {
                if (øjne == 5)
                {
                    // Hvis øjne er 1, så læg det til summen af femere
                    e1 += øjne;
                }
            }
            //Seksere

            // Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 6
            foreach (int øjne in minArray1)
            {
                if (øjne == 6)
                {
                    // Hvis øjne er 1, så læg det til summen af seksere
                    f1 += øjne;
                }
            }

            //Et par

            foreach (int øjne in minArray1)
            {
                if (øjne == 1 && øjne == 1 || øjne == 2 && øjne == 2 || øjne == 3 && øjne == 3 || øjne == 4 && øjne == 4 || øjne == 5 && øjne == 5 || øjne == 6 && øjne == 6)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    g1 = 50;
            }

            //To par

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    h1 = 50;
            }

            //Tre ens:MANGLER

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    i1 = 50;
            }
            //Fire ens

            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    j1 = 50;
            }
            //Lille Straight
            k1 = 0;
            //Store Straight
            l1 = 0;
            //chancen er summen af alle 5 terninger
            m1 = (terning1 + terning2 + terning3 + terning4 + terning5);
            //Yatzy 50 point
            n1 = 0;
            foreach (int øjne in minArray1)
            {
                if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
                    // Hvis øjne er 1, så læg det til summen af seksere
                    n1 = 50;
            }


            ////////Spiller 3
            ////////Enere
            //////a2 = 0;

            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 1
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 1)
            //////    {
            //////        // Hvis øjne er 1, så læg det til summen af enere
            //////        // Vi lægger værdien af variablen øjne til værdien af variablen a og gemmer resultatet tilbage i a. a+=øjne er det samme som a=a+øjne
            //////        a2 = a2 + øjne;
            //////    }
            //////}

            ////////Toere
            //////b2 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 2
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 2)
            //////    {
            //////        // Hvis øjne er 2, så læg det til summen af toere
            //////        b2 += øjne;
            //////    }
            //////}
            ////////Trere
            //////c2 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 3
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 3)
            //////    {
            //////        // Hvis øjne er 3, så læg det til summen af trere
            //////        c2 += øjne;
            //////    }
            //////}
            ////////Fire
            //////d2 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 4
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 4)
            //////    {
            //////        // Hvis øjne er 4, så læg det til summen af fire
            //////        d2 += øjne;
            //////    }
            //////}
            ////////Femere
            //////e2 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 5
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 5)
            //////    {
            //////        // Hvis øjne er 1, så læg det til summen af femere
            //////        e2 += øjne;
            //////    }
            //////}
            ////////Seksere
            //////f2 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 6
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6)
            //////    {
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        f2 += øjne;
            //////    }
            //////}

            ////////Et par
            //////g2 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 1 && øjne == 1 || øjne == 2 && øjne == 2 || øjne == 3 && øjne == 3 || øjne == 4 && øjne == 4 || øjne == 5 && øjne == 5 || øjne == 6 && øjne == 6)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        g2 = 50;
            //////}

            ////////To par
            //////h2 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        h2 = 50;
            //////}

            ////////Tre ens:MANGLER
            //////i2 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        i2 = 50;
            //////}
            ////////Fire ens
            //////j2 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        j2 = 50;
            //////}
            ////////Lille Straight
            //////k2 = 0;
            ////////Store Straight
            //////l2 = 0;
            ////////chancen er summen af alle 5 terninger
            //////m2 = (terning1 + terning2 + terning3 + terning4 + terning5);
            ////////Yatzy 50 point
            //////n2 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        n2 = 50;
            //////}


            ////////Spiller 4
            ////////Enere
            //////a3 = 0;

            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 1
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 1)
            //////    {
            //////        // Hvis øjne er 1, så læg det til summen af enere
            //////        // Vi lægger værdien af variablen øjne til værdien af variablen a og gemmer resultatet tilbage i a. a+=øjne er det samme som a=a+øjne
            //////        a3 = a3 + øjne;
            //////    }
            //////}

            ////////Toere
            //////b3 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 2
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 2)
            //////    {
            //////        // Hvis øjne er 2, så læg det til summen af toere
            //////        b3 += øjne;
            //////    }
            //////}
            ////////Trere
            //////c3 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 3
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 3)
            //////    {
            //////        // Hvis øjne er 3, så læg det til summen af trere
            //////        c3 += øjne;
            //////    }
            //////}
            ////////Fire
            //////d3 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 4
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 4)
            //////    {
            //////        // Hvis øjne er 4, så læg det til summen af fire
            //////        d3 += øjne;
            //////    }
            //////}
            ////////Femere
            //////e3 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 5
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 5)
            //////    {
            //////        // Hvis øjne er 1, så læg det til summen af femere
            //////        e3 += øjne;
            //////    }
            //////}
            ////////Seksere
            //////f3 = 0;
            //////// Gennemgå hvert terningkast som er gemt i minArray1 og se efter om det er lig med 6
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6)
            //////    {
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        f3 += øjne;
            //////    }
            //////}

            ////////Et par
            //////g3 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 1 && øjne == 1 || øjne == 2 && øjne == 2 || øjne == 3 && øjne == 3 || øjne == 4 && øjne == 4 || øjne == 5 && øjne == 5 || øjne == 6 && øjne == 6)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        g3 = 50;
            //////}

            ////////To par
            //////h3 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        h3 = 50;
            //////}

            ////////Tre ens:MANGLER
            //////i3 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        i3 = 50;
            //////}
            ////////Fire ens
            //////j3 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        j3 = 50;
            //////}
            ////////Lille Straight
            //////k3 = 0;
            ////////Store Straight
            //////l3 = 0;
            ////////chancen er summen af alle 5 terninger
            //////m3 = (terning1 + terning2 + terning3 + terning4 + terning5);
            ////////Yatzy 50 point
            //////n3 = 0;
            //////foreach (int øjne in minArray1)
            //////{
            //////    if (øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 && øjne == 6 || øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 && øjne == 5 || øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 && øjne == 4 || øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 && øjne == 3 || øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 && øjne == 2 || øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1 && øjne == 1)
            //////        // Hvis øjne er 1, så læg det til summen af seksere
            //////        n3 = 50;
            //////}





            Console.ReadLine();


        }
    }
}
