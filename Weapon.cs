class Weapon
{
    public string WeaponName;
    public int Damage;

    public Weapon(string weaponName, int damage)
    {
        WeaponName = weaponName;
        Damage = damage;
    }

    public static bool operator >(Weapon w1, Weapon w2)
    {
        return w1.Damage > w2.Damage;
    }

    public static bool operator <(Weapon w1, Weapon w2)
    {
        return w1.Damage < w2.Damage;
    }
}