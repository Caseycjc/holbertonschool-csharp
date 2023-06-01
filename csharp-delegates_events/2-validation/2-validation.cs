/// <summary>
/// Represents a Player with health points.
/// </summary>
public class Player
{
    /// <summary>
    /// Health Value.
    /// </summary>
    public delegate void CalculateHealth(float amount);

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
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            System.Console.WriteLine($"{name} takes 0 damage!");
            return;
        }

        float newHp = hp - damage;
        System.Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// The player heals damage.
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            System.Console.WriteLine($"{name} heals 0 HP!");
            return;
        }

        float newHp = hp + heal;
        System.Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates and sets the player's current health points.
    /// </summary>
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
    /// Prints the player's current health status.
    /// </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
