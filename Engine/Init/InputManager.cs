using Microsoft.Xna.Framework.Input;
using rpgmono;

public static class InitInputManager
{
    public static void UpdateInput(Microsoft.Xna.Framework.GraphicsDeviceManager graphics, Player player)
    {
        // KEYBOARD INPUT HANDLING
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            player.Move(new Microsoft.Xna.Framework.Vector2(0, -1));
            System.Console.WriteLine("W key pressed (MOVE UP)");
            
        }
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            player.Move(new Microsoft.Xna.Framework.Vector2(-1, 0));
            System.Console.WriteLine("A key pressed (MOVE LEFT)");
        }
        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            player.Move(new Microsoft.Xna.Framework.Vector2(0, 1));
            System.Console.WriteLine("S key pressed (MOVE DOWN)");
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            player.Move(new Microsoft.Xna.Framework.Vector2(1,0));
            System.Console.WriteLine("D key pressed (MOVE RIGHT)");
        }


            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                System.Environment.Exit(0);
                System.Console.WriteLine("Exiting...");
            }
            if (Keyboard.GetState().IsKeyDown(Keys.F11))
            {
                graphics.ToggleFullScreen();
                System.Console.WriteLine("Toggled Fullscreen");
            }


            // MOUSE INPUT HANDLING
            if (Mouse.GetState().RightButton == ButtonState.Pressed)
            {
                System.Console.WriteLine("Right mouse button pressed");
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                System.Console.WriteLine("Left mouse button pressed");
            }
            if (Mouse.GetState().MiddleButton == ButtonState.Pressed)
            {
                System.Console.WriteLine("Middle mouse button pressed");
            }

    }
}