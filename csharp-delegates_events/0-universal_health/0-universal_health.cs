/// <summary>
/// Represents a Player with health points.
/// </summary>
public class Player
{
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
    /// Prints the player's current health status.
    /// </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
