namespace SimpleTranslationSystem
{
    public static class TranslationSystem
    {
        private static Language language;

        public static void SetLanguage(Language language)
        {
            TranslationSystem.language = language;
        }

        public static Language GetLanguage()
        {
            return language;
        }

        public static string GetText(string text, bool caseSensitive = false)
        {
            return GetText(text, language, caseSensitive);
        }

        public static string GetText(string text, Language language, bool caseSensitive = false)
        {
            return language.GetText(text, caseSensitive);
        }
    }
}
