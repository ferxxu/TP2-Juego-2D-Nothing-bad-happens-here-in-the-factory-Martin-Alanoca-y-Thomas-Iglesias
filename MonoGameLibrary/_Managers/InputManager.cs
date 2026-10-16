using System.Numerics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameLibrary;

public static class InputManager
{
    private static Vector2 _direccion;
    public static Vector2 Direccionc=> _direccion;
    public static bool Movingc=> _direccion != Vector2.Zero;

    public static void Update()
    {
        _direccion = Vector2.Zero;
        var KeyboardState = Keyboard.GetState();

        if(KeyboardState.GetPressedKeyCount() > 0)
        {
            if(KeyboardState.IsKeyDown(Keys.A)) _direccion.X--;
            if(KeyboardState.IsKeyDown(Keys.D)) _direccion.X++;
        }
    }
}