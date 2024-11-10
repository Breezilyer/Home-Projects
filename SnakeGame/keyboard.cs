using System.Runtime.InteropServices;

namespace RealTimeInput;

public class Keyboard
{
    [DllImport("user32.dll")]
    private static extern short GetKeyState(int nVKey);

    public static bool IsKeyDown(int key)
    {
        return (GetKeyState(key) & (0b1000_0000_0000_0000)) != 0;
    }

    public static bool IsKeyToggled(int key)
    {
        return (GetKeyState(key) & (0b1)) != 0;
    }
}