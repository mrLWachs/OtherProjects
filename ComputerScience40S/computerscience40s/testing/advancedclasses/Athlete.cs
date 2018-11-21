using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Athlete - represents an athlete husky computer science high school 
    /// </summary>
    class Athlete : Husky, Golf, LOL, PermissionForm
    {

        private string playerName;
        private string opponentName;
        private int playerScore;
        private int opponentScore;
        private int healthPlayer;
        private int healthOpponent;
        private bool isSigned;

        /// <summary>
        /// Constructor for the class, sets class properties
        /// </summary>
        /// <param name="name">the name for this object</param>
        /// <param name="age">the age for this object</param>
        /// <param name="isMale">the gender for this object</param>
        /// <param name="studentNumber">the student number for this object</param>
        public Athlete(string name, int age, bool isMale, 
            int studentNumber) : base(name,age,isMale,studentNumber)
        {
            isSigned = false;
            healthPlayer = 100;
            healthOpponent = 100;
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            return "Athlete " + base.ToString();
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            return base.Equals(item);
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public Athlete Clone()
        {
            return this;
        }

        /// <summary>
        /// The player gets a score for the hole
        /// </summary>
        /// <param name="score">the player's score</param>
        public void PlayPlayer(int score)
        {
            playerScore += score;
        }

        /// <summary>
        /// The opponent gets a score for the hole
        /// </summary>
        /// <param name="score">the opponent's score</param>
        public void PlayOpponent(int score)
        {
            opponentScore += score;
        }

        /// <summary>
        /// The end of this hole
        /// </summary>
        /// <param name="hole">the current hole</param>
        public void End(int hole)
        {
            Tester.print("Player " + playerName +
                " got a " + playerScore + " so far " +
                "and " + opponentName + " has a " +
                opponentScore + " by hole " + hole);
        }

        /// <summary>
        /// Mutator setting the name of the player
        /// </summary>
        /// <param name="name">the name of this player</param>
        public void SetPlayer(string name)
        {
            playerName = name;
        }

        /// <summary>
        /// Mutator setting the name of the opponent
        /// </summary>
        /// <param name="name">the name of this opponent</param>
        public void SetOpponent(string name)
        {
            opponentName = name;
        }

        /// <summary>
        /// Signing the permission form
        /// </summary>
        public void Sign()
        {
            isSigned = true;
        }

        /// <summary>
        /// Determines if the form is signed or not
        /// </summary>
        /// <returns>form is signed or not</returns>
        public bool HaveGotSigned()
        {
            return isSigned;
        }

        /// <summary>
        /// The player inflicts some damage
        /// </summary>
        /// <param name="damage">the amount of damage inflicted</param>
        public void PlayerFights(int damage)
        {
            healthOpponent -= damage;
        }

        /// <summary>
        /// The opponent inflicts some damage
        /// </summary>
        /// <param name="damage">the amount of damage inflicted</param>
        public void OpponentFights(int damage)
        {
            healthPlayer -= damage;
        }

        /// <summary>
        /// The game ends
        /// </summary>
        public void GameOver()
        {
            if (healthPlayer > healthOpponent)
            {
                Tester.print("Player wins");
            }
            else
            {
                Tester.print("Opponent wins");
            }
        }

    }
}
