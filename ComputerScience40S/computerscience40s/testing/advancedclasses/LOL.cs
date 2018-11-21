using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// 
    /// </summary>
    interface LOL
    {

        /// <summary>
        /// The player inflicts some damage
        /// </summary>
        /// <param name="damage">the amount of damage inflicted</param>
        void PlayerFights(int damage);

        /// <summary>
        /// The player inflicts some damage
        /// </summary>
        /// <param name="damage">the amount of damage inflicted</param>
        void OpponentFights(int damage);

        /// <summary>
        /// The game ends
        /// </summary>
        void GameOver();

    }
}
