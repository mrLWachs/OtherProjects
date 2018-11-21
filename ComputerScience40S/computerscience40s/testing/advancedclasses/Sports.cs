using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Sports - interface enforcing the rules of sports
    /// </summary>
    interface Sports
    {

        /// <summary>
        /// Mutator setting the name of the player
        /// </summary>
        /// <param name="name">the name of this player</param>
        void SetPlayer(string name);

        /// <summary>
        /// Mutator setting the name of the opponent
        /// </summary>
        /// <param name="name">the name of this opponent</param>
        void SetOpponent(string name);

    }
}
