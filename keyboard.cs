namespace _01;
static class KeyBoard
{
    public static char GetYesOrNo()
    {
        char key;
        do
        {
            key = Console.ReadKey(true).KeyChar;
        } while (key != 'y' && key != 'n' && key != 'Y' && key != 'N');
        Console.WriteLine(key);
        return key;
    }
}