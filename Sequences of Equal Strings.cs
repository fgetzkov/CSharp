using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello";
            int count = 1;
            List<string> listStr = new List<string>();
            List<int> tempListStr = new List<int>();
            foreach (var word in input.Split(' '))
            {
                listStr.Add(word);
            }
            for (int i = 0; i < listStr.Count;)
            {
                for (int j = i+1; j < listStr.Count; j++)
                {
                    if (listStr[i].Equals(listStr[j]))
                    {
                        count++;
                    }
                }
                tempListStr.Add(count);
                i=i + (count);
                count = 1;
            }
            List<string> NoDuplicates = listStr.Distinct().ToList();
            for (int i = 0; i < NoDuplicates.Count(); i++)
            {
                for (int j = 0; j < tempListStr[i]; j++)
                {
                    Console.Write(NoDuplicates[i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
