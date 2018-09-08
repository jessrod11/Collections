using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[5];

            var three = 3.ToString();

            /*if (true)
                DoSomething();*/
                
            //Same as below

           /* if (true)
            {
                DoSomething();
            }*/

            // Collections - Lists

            var list = new List<string>
            {
                "Martin",
                "Ben",
                three
            };

            list.Add("Nathan");

            Predicate<string> temp = x => x == "Martin";

            var martinExists = list.Exists(temp);

            // var dictionary = new Dictionary<int, string>();

            // Collections - Dictionary

            var spouses = new Dictionary<MiniFigure, MiniFigure>();

            var todd = new MiniFigure();
            var toddSpouse = new MiniFigure();
            spouses.Add(todd, toddSpouse);
            // this example "just performed a wedding lol"
            var spouseKeys = spouses.Keys;

            // var toddRealSpouse; must be implicitly typed or initialized with a value

            //MiniFigure toddRealSpouse; same as what is listed below. it is being declared outside in this case.
        
            spouses.TryGetValue(todd, out  MiniFigure toddRealSpouse);

            // Collections - Tuple 
            var tuple = new Tuple< string, int, MiniFigure>("Martin", 42, todd);

            var name = tuple.Item1;
        }

        static void DoSomething()
        {
            Console.WriteLine("Something");
        } 

        public class MiniFigure
        {

        };
    }
}
