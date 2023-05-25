using System;

namespace Enemies
{
    ///<summary>
    /// Defines a Zombie.
    ///</summary>
    public class Zombie
    {
        ///<summary>
        /// Private field for the health of the Zombie.
        ///</summary>
        private int health;

        ///<summary>
        /// Private field for the name of the Zombie. Default is "(No name)".
        ///</summary>
        private string name = "(No name)";

        ///<summary>
        /// Public constructor that sets health to 0.
        ///</summary>
        public Zombie()
        {
            this.health = 0;
        }

        ///<summary>
        /// Public constructor that sets the health to the given value. 
        /// Throws ArgumentException if the value is less than 0.
        ///</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }

        ///<summary>
        /// Public property for name. Allows getting and setting the name.
        ///</summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        ///<summary>
        /// Returns the health of the Zombie.
        ///</summary>
        public int GetHealth()
        {
            return this.health;
        }

        ///<summary>
        /// Overrides the ToString method to display the Zombie's attributes.
        ///</summary>
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}
