
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
        if(Position.X < 0)
        {
            Position = new Vector2(0, Position.Y);
        }
        if(Position.Y < 0)
        {
            Position = new Vector2(Position.X, 0);
        }
        if (Position.X > 1280 - Texture.Width)
        {
            Position = new Vector2(1280 - Texture.Width, Position.Y);
        }
        if (Position.Y > 720 - Texture.Height)
        {
            Position = new Vector2(Position.X, 720 - Texture.Height);
        }
        if (direction != Vector2.Zero)
        {
            direction.Normalize();
        }
        Position += direction * MovementSpeed;
    }
}