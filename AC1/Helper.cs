using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC1
{
    public static class Helper
    {

        // Comprova si un valor està dins d'un rang
        public static bool BetweenRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        // Retorna les puntuacions máximes de cada jugador per missió
        public static List<Score> GenerateUniqueRanking(List<Score> scores)
        {
            List<Score> ranking = new List<Score>();


            // Es guarda la puntuació màxima de cada jugador per missió (groupby múltiple generat per Copilot)
            ranking =   scores.GroupBy(s => new { s.Player, s.Mission })
                        .Select(g => g.OrderByDescending(s => s.Scoring).First())
                        .ToList();


            // Es retorna la llista ordenada de manera descendent per puntuació
            return ranking.OrderByDescending(s => s.Scoring).ToList();
        }
    }
}
