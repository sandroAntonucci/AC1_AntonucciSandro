using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AC1
{
    public class Score
    {

        const int Zero = 0, FiveHundred = 500;

        const string PatternPlayer = @"^[a-zA-Z]+$";
        const string PatternMission = @"^(Beta|Gamma|Delta|Zeta|Theta|Kappa|Lambda|Mu|Nu|Xi|Pi|Rho|Sigma|Tau|Phi)-\d{3}$";

        const string ErrorPlayer = "\nError: El nom del jugador només pot contenir caràcters alfabètics (sense accents ni caràcters especials)";
        const string ErrorMission = "\nError: La missió ha de contenir com a prefix el nom adaptat de les consonants en grec, seguit d’un guió i un número de 3 xifres. Per exemple: Delta-003";
        const string ErrorScoring = "\nError: La puntuació ha de ser un número entre 0 i 500 (inclosos)";

        // Es fa amb atributs ja que hem de comprovar que compleixin els requisits
        private string player;
        private string mission;
        private int scoring;

        public string Player
        {
            get { return player; }

            set
            {
                // Es crea el regex
                Regex rg = new Regex(PatternPlayer);

                // Es comprova si el valor passat compleix el regex
                if (rg.IsMatch(value))
                {
                    player = value;
                }
                else
                {
                    throw new ArgumentException(ErrorPlayer);
                }
            }
        }

        public string Mission
        {
            get { return mission; }
            set
            {
                // Es crea el regex
                Regex rg = new Regex(PatternMission);

                // Es comprova si el valor passat compleix el regex
                if (rg.IsMatch(value))
                {
                    mission = value;
                }
                else
                {
                    throw new ArgumentException(ErrorMission);
                }
            }
        }

        public int Scoring
        {
            get { return scoring; }
            set
            {
                // Es comprova si el valor passat està entre 0 i 500
                if (Helper.BetweenRange(value, Zero, FiveHundred))
                {
                    scoring = value;
                }
                else
                {
                    throw new ArgumentException(ErrorScoring);
                }
            }
        }

        public Score(string player, string mission, int scoring)
        {
            Player = player;
            Mission = mission;
            Scoring = scoring;
        }
    }
}