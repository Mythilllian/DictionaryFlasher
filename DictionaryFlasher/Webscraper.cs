using HtmlAgilityPack;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;

namespace DictionaryFlasher
{
    public static class Webscraper
    {
        static Dictionary<string, string[]> transdefinitionTable = new Dictionary<string, string[]>();

        public static string[] GetInfo(string word, string definition, string partofspeech)
        {
            if (transdefinitionTable.TryGetValue(word, out var ttInfo))
            {
                return ttInfo;
            }

            var web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc;
            try
            {
                doc = web.Load("https://thesaurus.com/browse/" + word);
            }
            catch { throw; };
            try
            {
                if (!doc.DocumentNode.SelectSingleNode(("//button[@id='thesaurus-entry-" + word + "-tab-0']")).InnerText.Contains(partofspeech[0..3].ToLower()))
                {
                    return new string[1] { "[MANUAL]" };
                }
            }
            catch { return new string[1] { "[MANUAL]" }; }
            

            HtmlNodeCollection node;
            node = doc.DocumentNode.SelectNodes("//a[@data-type='pill-button']");
            string[] output = GetUnique(definition, node);

            transdefinitionTable.Add(word, output);
            return output;
        }

        private static string[] GetUnique(string definition, HtmlNodeCollection nodes, int numToGet = 2)
        {
            List<string> strings = new List<string>();
            string lowerDefinition = definition.ToLower();

            foreach(var node in nodes)
            {
                if (!lowerDefinition.Contains(node.InnerText))
                {
                    strings.Add(node.InnerText) ;
                    if(strings.Count >= numToGet)
                    {
                        break;
                    }
                }
            }
            return strings.ToArray();
        }
    }
}
