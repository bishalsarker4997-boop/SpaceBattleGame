class Player : Character, IAttack
{
    public Spaceship Ship;
    public Weapon Weapon;

    public Player(string name, int health,
        Spaceship ship, Weapon weapon)
        : base(name, health)
    {
        Ship = ship;
        Weapon = weapon;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("\n===== PLAYER INFO =====");
        Console.WriteLine("Name   : " + Name);
        Console.WriteLine("Health : " + Health);
        Console.WriteLine("Ship   : " + Ship.ShipName);
        Console.WriteLine("Fuel   : " + Ship.Fuel);
        Console.WriteLine("Energy : " + Ship.Energy);
        Console.WriteLine("Weapon : " + Weapon.WeaponName);
    }

    public void Attack(Alien alien)
    {
        if (Ship.Energy >= 10)
        {
            alien.TakeDamage(Weapon.Damage);
            Ship.Energy -= 10;

            Console.WriteLine(
                Name + " attacked " +
                alien.Name + " with " +
                Weapon.WeaponName);
        }
        else
        {
            Console.WriteLine("Not enough energy!");
        }
    }

    // Function Overloading
    public void Attack(Alien alien, int bonusDamage)
    {
        if (Ship.Energy >= 15)
        {
            alien.TakeDamage(
                Weapon.Damage + bonusDamage);

            Ship.Energy -= 15;

            Console.WriteLine(
                "Special Attack! Damage = " +
                (Weapon.Damage + bonusDamage));
        }
        else
        {
            Console.WriteLine("Not enough energy!");
        }
    }
}