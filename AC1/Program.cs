using System;

namespace AC1
{
    class Program
    {
        static void Main()
        {
            const int Zero = 0, One = 1, Ten = 10;

            const string MsgScore = "\n\n--- Puntuació de la missió {0} ---";
            const string MsgPlayer = "\n - Introdueix el nom del jugador (només caràcters alfabètics): ";
            const string MsgMission = " - Introdueix el nom de la missió (nom de consonant en grec, un guió i un nombre de tres dígits: Delta-003): ";
            const string MsgScoring = " - Introdueix la puntuació de la missió: ";
            const string MsgRankingHeader = "\n\n--- Rànquing de puntuacions ---";
            const string MsgRanking = "\n{0} - {1} - {2}";

            int scoring = Zero, numScores = Zero;

            bool statOK = false;

            string player = "", mission = "";

            List<Score> scores = new List<Score>();

            // Es creen 10 puntuacions

            while(numScores < Ten)
            {

                Console.WriteLine(MsgScore, numScores + One);

                // Try-catch per si no s'introdueixen correctament els valors
                try
                {

                    // S'introdueixen els valors
                    Console.Write(MsgPlayer);
                    player = Console.ReadLine();

                    Console.Write(MsgMission);
                    mission = Console.ReadLine();

                    Console.Write(MsgScoring);
                    scoring = Convert.ToInt32(Console.ReadLine());

                    // Es crea l'objecte score (throw exception per valors invàlids)
                    Score score = new Score(player, mission, scoring);

                    // S'afegeix a la llista de puntuacions i es crea una nova
                    scores.Add(score);
                    numScores++;

                }
                catch (Exception exc)
                {
                    // Mostra el missatge d'error
                    Console.WriteLine(exc.Message);

                }

            }

            // Es genera el ranking
            List<Score> ranking = Helper.GenerateUniqueRanking(scores);

            // Es mostra el ranking
            Console.WriteLine(MsgRankingHeader);
            foreach (Score score in ranking)
            {
                Console.WriteLine(MsgRanking, score.Player, score.Mission, score.Scoring);
            }

            Console.ReadLine();
        }
    }
}