# SimpleTranslationSystem
Simple Translation System is exactly what it looks like. It's purpose is to provide a simple way to translate your app to whatever language you wish to!
  
### How to use
1. Load a translation file
   - `TranslationSystem.SetLanguagesFromCSVFile(string pathToCsvFile)`
2. Set the language
   - `TranslationSystem.SetLanguage(string code)`
3. Get text
   - `TranslationSystem.GetText(string identifier)`

Optionals:
- Before the first step, you can set a custom column separator by doing `TranslationSystem.SetColumnSeparator(char columnSeparator`

Other:
- Your .csv files should be formatted like this:

| id          | en          | fi                   | sv          | de             |
|:------------|:------------|:---------------------|:------------|:---------------|
| hello       | hello       | hei                  | hej         | hallo          |
| how are you | how are you | mitä kuuluu          | hur mår du  | wie geht's     |
| I'm fine    | I'm fine    | minulle kuuluu hyvää | jag mår bra | mir geht's gut |
| thanks      | thanks      | kiitos               | tack        | danke          |

The identifier in the id column can be called whatever you want. It will be the id that you will use when accessing a translation.

The language codes (in this case, "en", "fi", "sv", and "de") can also be whatever you want, but it will make it clearer if you use the actual code of the language (can be found [here](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes))
