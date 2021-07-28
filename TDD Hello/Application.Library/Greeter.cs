using System;
using System.Collections.Generic;

namespace Application.Library
{
    public static class Greeter
    {
        public static string Greet(params string[] names)
        {
            if (names[0] == null) return "Hello, my friend.";

            if (names.Length == 1) return $"Hello, {names[0]}.";

            List<string> lowercaseNames = SeparatorLowerCase(names);
            List<string> uppercaseNames = SeparatorUpperCase(names);

            if (names.Length == 1 && uppercaseNames.Contains(names[0])) return $"HELLO, {names[0]}."; 

            return "Not implemented yet";
        }

        public static List<string> SeparatorLowerCase(string[] names)
        {
            List<string> lowercaseNames = new();

            foreach(string name in names)
            {
                if(!name.ToUpper().Equals(name))
                {
                    lowercaseNames.Add(name);
                }
            }

            return lowercaseNames;
        }

        public static List<string> SeparatorUpperCase(string[] names)
        {
            List<string> uppercaseNames = new();

            foreach (string name in names)
            {
                if (!name.ToLower().Equals(name))
                {
                    uppercaseNames.Add(name);
                }
            }

            return uppercaseNames;
        }
    }
}
