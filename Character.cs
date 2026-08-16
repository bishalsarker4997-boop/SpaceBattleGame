abstract class Character
{
    protected string name;
    protected int health;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public abstract void ShowInfo();

    public virtual void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
            health = 0;
    }
}