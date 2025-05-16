using System.Reflection.Metadata;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace rpgmono;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private Player player;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        //INITIALIZATION CODE
       
        InitGraphicsSettings.ApplySettings(_graphics);
        player = new Player("Warrior");
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        player.LoadPlayerContent(Content);
    }

    protected override void Update(GameTime gameTime)
    {

        InitInputManager.UpdateInput(_graphics, player);
        base.Update(gameTime);
        
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        // Draw the player
        _spriteBatch.Draw(player.Texture, player.Position, Color.White);
        _spriteBatch.End();
        

        base.Draw(gameTime);
    }
}
