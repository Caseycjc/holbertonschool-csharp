using System;

/// <summary>
/// EventArgs derived class which contains the current health of the Player.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Gets the current health points.
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// Initializes a new instance of CurrentHPArgs.
    /// </summary>
    /// <param name="newHp">Current health points.</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

/// <summary>
/// Player class for handling player actions.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary>
    /// Delegate to calculate health.
    /// </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Delegate to calculate modifier.
    /// </summary>
    public delegate float CalculateModifier(float baseValue, Modifier modifier);

    /// <summary>
    /// Event triggered when health points are validated.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Constructor for Player.
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Print the current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Damage the player.
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Heal the player.
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validate the health points.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        hp = Math.Clamp(newHp, 0, maxHp);
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Checks the status of the player.
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status = $"{name} is knocked out!";
        }
        Console.WriteLine(status);
    }

    /// <summary>
    /// Applies the modifier to a base value.
    /// </summary>
    public static float ApplyModifier(float baseValue, Modifier modifier)
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
}

/// <summary>
/// Enum to determine the strength of an attack.
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}
