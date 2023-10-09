using System.Collections.Generic;

namespace DictionaryFlasher
{
    public enum FormatType
    {
        Form8,
        Form7,
        Quizlet,
        Blooket
    }

    public static class Formatter
    {
        /*
        
        Added Form8, still using Form7 for Quizlet and Blooket
        
        Form7:
        [Word] (definition)-[Definition]
        [Word] (part of speech)-[Definition]

        Form8:
        [Word] - ([Part of speech]) - [synonym1]; [synonym2]; [definition]
         
        */
        public static string Format(string word, string definition, string partofspeech, FormatType type)
        {
            string[] synonyms = Webscraper.GetInfo(word, definition, partofspeech);

            foreach (string synonym in synonyms)
            {
                definition = definition.Insert(0, synonym + "; ");
            }

            word = $"{word[0].ToString().ToUpper()}{word.Substring(1)}";
            definition = $"{definition[0].ToString().ToUpper()}{definition.Substring(1)}";
            partofspeech = $"{partofspeech[0].ToString().ToUpper()}{partofspeech.Substring(1)}";

            //Modifies definition to match definition in Format7
            if (type != FormatType.Form8)
            {
                definition = definition[0] == '('
                    ? definition.Split(") ")[1]
                    : definition;

                if (char.IsPunctuation(definition[definition.Length - 1]))
                {
                    definition = definition.Substring(0, definition.Length - 1) + '.';
                }
                else
                {
                    definition += '.';
                }
            }

            switch (type)
            {
                case FormatType.Quizlet:
                    return word + " (definition)-" + definition + "\r\n" + word + " (part of speech)-" + partofspeech;
                case FormatType.Blooket:
                    return definition + "\t" + word + " (definition)\r\n" + partofspeech + "\t" + word + " (part of speech)";
                case FormatType.Form7:
                    return word + " (definition)-" + definition + "\r\n" + word + " (part of speech)-" + partofspeech + "\r\nSentence: \r\n";
                default:
                    return word + " - (" + partofspeech + ") - " + definition + ".\r\n1.\r\n";
            }
        }

        public static string FormatInput(string input, FormatType type)
        {
            List<string> words = new List<string>();
            List<string> definitions = new List<string>();
            List<string> partsofspeech = new List<string>();

            foreach (string line in input.Split('\n', StringSplitOptions.RemoveEmptyEntries))
            {
                string _line = line.Trim();

                if (_line.StartsWith("Part of Speech:"))
                {
                    partsofspeech.Add(_line.Split("Part of Speech:")[1].Trim());
                }
                else if (char.IsLower(_line[0]))
                {
                    words.Add(_line.Split(' ')[0]);
                    definitions.Add(string.Concat(_line.Split(":")[1..]).Trim());
                }
            }

            string output = "";
            for (int i = 0; i < words.Count; i++)
            {
                output += Format(words[i], definitions[i], partsofspeech[i], type) + "\r\n";
            }
            output = output.TrimEnd();
            return output;
        }
    }
}
