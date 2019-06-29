namespace SimpleTranslationSystem
{
    [System.Serializable]
    public struct Translation
    {
        public string text;
        public string translation;

        public Translation(string text, string translation)
        {
            this.text = text;
            this.translation = translation;
        }
    }
}