using System;

namespace Enemies
{
    ///<summary>
    /// This is a class
    /// </summary>
    public class Zombie
    {
        ///<summary>
        /// public int
        ///</summary>
        public int health;
        ///<summary>
        /// public constructor
        ///</summary>

        public Zombie()
        {
            health = 0;
        }

        ///<summary>
        /// new constructor that is for the zombie's health
        ///</summary>
public Zombie(int value)
{
    if (value < 0)
    {
        throw new ArgumentException("Health must be greater than or equal to 0");
    }
    else
    {
        health = value;
    }
}

///<summary>
///returns health value
///</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
