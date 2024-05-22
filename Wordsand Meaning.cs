using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDictionaryAndSetOperators
{
    class Wordsand_Meaning
    {
        /// <summary>
        /// Declaring two private properties that defines words and meaning that will be contained in wordDictionary
        /// </summary>

        private Dictionary<string, string> wordDictionary;

        /// <summary>
        /// Using the constructor initialize the properties and store ten words and their respective meanings in the wordDictionary
        /// </summary>

        public Wordsand_Meaning()
        {
            wordDictionary = new Dictionary<string, string>
     {
         {"Aberration:", "A departure from the norm or original"},
         {"Capricous:", "Being given to sudden changes in mood or behaviour"},
         {"Sycophant:", "A person who acts obsequiously towards someone important in order to gain advantage"},
         {"Ineffable:", "Too great or extreme to be expressed in words"},
         {"Pernicious:", "Having a harmful effect, especially in a gradual or subtle way"},
         {"Ephemeral:", "Lasting for a very short time"},
         {"Garrulous:", "Excessively talkative, especially on trivial matter"},
         {"Feeble:", "Markedly lacking in strenght"},
         {"Zenith:", "The highest point reached in the heavens by a celestial body"},
         {"Voracious:", "Having a huge appetite"},


     };

        }
        /// <summary>
        /// The method PrintWords loops through the dictionary and prints all the words and meaning in them.
        /// </summary>
        public void PrintWords()
        {
            foreach (var word in wordDictionary)
            {
                Console.WriteLine(word);
            }
        }
    }
}
