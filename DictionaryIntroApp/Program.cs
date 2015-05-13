using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(101, "CSE101");
            myDictionary.Add(102, "CSE102");
            myDictionary.Add(103, "EEE111");
            myDictionary.Add(104, "EEE222");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Remove(103);

            Console.WriteLine(myDictionary.Count);

            Console.WriteLine(myDictionary[101]);

            foreach (KeyValuePair<int, string> keyValuePair in myDictionary)
            {
                Console.WriteLine(keyValuePair.Key + " " +keyValuePair.Value);
                
            }

            Console.ReadKey();
        }
    }
}
