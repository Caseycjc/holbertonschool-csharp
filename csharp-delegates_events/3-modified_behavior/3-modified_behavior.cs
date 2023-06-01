/// <summary>
/// Represents the strength of a modifier.
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// Represents a Player with health points.
/// </summary>
public class Player
{
    // Delegate to calculate health.
    public delegate void CalculateHealth(float amount);

    // Delegate to calculate modified value.
    public delegate float CalculateModifier(float baseValue, Modifier modifier);

    /// <summary>
    /// The name of the player.
    /// </summary>
    private string name;

    /// <summary>
    /// The maximum health points the player can have.
    /// </summary>
    private float maxHp;

    /// <summary>
    /// The current health points of the player.
    /// </summary>
    private float hp;

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player. Defaults to "Player".</param>
    /// <param name="maxHp">The maximum health points the player can have. Defaults to 100f.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    /// The player takes damage.
    /// </summary>
    /// <param name="damage">The amount of damage to take.</param>
    public void TakeDamage(float damage)
    {
        float newHp = hp - damage;
        System.Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// The player heals damage.
    /// </summary>
    /// <param name="heal">The amount of health to heal.</param>
    public void HealDamage(float heal)
    {
        float newHp = hp + heal;
        System.Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates and sets the player's current health points.
    /// </summary>
    /// <param name="newHp">The new health points to set.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    /// <summary>
    /// Applies a modifier to a base value.
    /// </summary>
    /// <param name="baseValue">The base value to modify.</param>
    /// <param name="modifier">The modifier to apply.</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2;
            case Modifier.Strong:
                return baseValue * 1.5f;
            case Modifier.Base:
            default:
                return baseValue;
        }
    }

    /// <summary>
    /// Prints the player's current health status.
    /// </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
