public static class InitGraphicsSettings
{
    public static int ScreenWidth { get; set; } = 1280;
    public static int ScreenHeight { get; set; } = 720;
    public static bool IsFullScreen { get; set; } = false;
    public static bool IsMouseVisible { get; set; } = true;
    public static bool AllowUserResizing { get; set; } = true;

    public static void ApplySettings(Microsoft.Xna.Framework.GraphicsDeviceManager graphics)
    {
        graphics.PreferredBackBufferWidth = ScreenWidth;
        graphics.PreferredBackBufferHeight = ScreenHeight;
        graphics.IsFullScreen = IsFullScreen;
        graphics.ApplyChanges();
    }
}