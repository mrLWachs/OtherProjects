using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Golf - interface enforcing the rules of golf
    /// </summary>
    interface Golf : Sports
    {

        /// <summary>
        /// The player gets a score for the hole
        /// </summary>
        /// <param name="score">the player's score</param>
        void PlayPlayer(int score);

        /// <summary>
        /// The opponent gets a score for the hole
        /// </summary>
        /// <param name="score">the opponent's score</param>
        void PlayOpponent(int score);

        /// <summary>
        /// The end of this hole
        /// </summary>
        /// <param name="hole">the current hole</param>
        void End(int hole);

    }
}
