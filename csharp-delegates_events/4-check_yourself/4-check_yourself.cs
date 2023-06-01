using System;

/// <summary>
/// Event arguments that contain the player's current health points.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// The current health points of the player.
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// Initializes a new instance of the CurrentHPArgs class.
    /// </summary>
    /// <param name="newHp">The current health points of the player.</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
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

    // Event triggered when health points are validated.
    public event EventHandler<CurrentHPArgs> HPCheck;

    private string name;
    private float maxHp;
    private float hp;
    private string status;

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

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    public void ValidateHP(float newHp)
    {
        hp = Math.Clamp(newHp, 0, maxHp);
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

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
}

public enum Modifier
{
    Weak,
    Base,
    Strong
}
