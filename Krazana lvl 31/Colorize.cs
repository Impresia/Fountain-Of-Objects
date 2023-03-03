





namespace Krazana.Colorize


{
    public static class Colorize
    {

        public static void Coloring(string texti, ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(texti);

        }
        public static void Coloring2(string texti, ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
            Console.Write(texti);
        }


    }
}