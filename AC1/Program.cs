using System;

namespace AC1
{
    class Program
    {
        static void Main()
        {
            const int Zero = 0, Ten = 10;

            const string MsgScore = "--- Puntuació de la missió {0} ---";
            const string MsgPlayer = "\n - Introdueix el nom del jugador (només caràcters alfabètics): ";
            const string MsgMission = " - Introdueix el nom de la missió (nom de consonant en grec, un guió i un nombre de tres dígits: Delta-003): ";
            const string MsgScoring = " - Introdueix la puntuació de la missió: ";

            int scoring;

            string player, mission;

            List<Score> scores = new List<Score>();


            // Es creen 10 puntuacions

            for(int i = Zero; i < 3; i++)
            {

                Console.WriteLine(MsgScore, i + 1);

                Console.Write(MsgPlayer);
                player = Console.ReadLine();

                Console.Write(MsgMission);
                mission = Console.ReadLine();

                Console.Write(MsgScoring);
                scoring = Convert.ToInt32(Console.ReadLine());

                Score score = new Score(player, mission, scoring);

                scores.Add(score);

                Console.WriteLine("\n\n");

            }


            // Es mostren les puntuacions

            foreach(Score score in scores)
            {
                Console.WriteLine("Jugador: {0}", score.Player);
                Console.WriteLine("Missió: {0}", score.Mission);
                Console.WriteLine("Puntuació: {0}", score.Scoring);
                Console.WriteLine("\n\n");
            }


        }
    }
}