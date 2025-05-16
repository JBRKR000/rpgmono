
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public int MovementSpeed { get; set; } = 2;
    public Texture2D Texture { get; set; }
    public Vector2 Position { get; set; }
    public Vector2 Velocity { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Mana = 50;
        Strength = 10;
        Agility = 10;
        Intelligence = 10;
        Level = 1;
        Experience = 0;
        Position = Vector2.Zero;
        Velocity = Vector2.Zero;
    }

    public void LoadPlayerContent(ContentManager content)
    {
        Texture = content.Load<Texture2D>("warrior_idle");
    }

    public void Move(Vector2 direction)
    {
        if(direction != Vector2.Zero)
        {
            direction.Normalize();
        }
        Position += direction * MovementSpeed;
    }
}