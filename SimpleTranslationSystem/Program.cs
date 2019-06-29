using System;

namespace SimpleTranslationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Language finnishLanguage = new Language("fi", new Translation[]
            {
                new Translation("Yes", "Kyllä"),
                new Translation("No", "Ei"),
                new Translation("Hello", "Hei"),
                new Translation("Welcome", "Tervetuloa")
            });

            if (args.Length >= 1)
            {
                Console.WriteLine(finnishLanguage.GetText(args[0]));
            }
        }
    }
}
