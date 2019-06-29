using System.Linq;

namespace SimpleTranslationSystem
{
    public class Language
    {
        public string identifier;
        public Translation[] translations;

        public Language(string identifier)
        {
            this.identifier = identifier;
        }

        public Language(string identifier, Translation[] translations)
        {
            this.identifier = identifier;
            this.translations = translations;
        }

        public string GetText(string text, bool caseSensitive = false)
        {
            Translation translation;
            if (caseSensitive)
            {
                translation = translations.FirstOrDefault(t => t.text == text);
            }
            else
            {
                translation = translations.FirstOrDefault(t => t.text.ToLower() == text.ToLower());
            }

            return translation.translation;
        }
    }
}