using System.Collections.Generic;

namespace Application.Library
{
    public static class Greeter
    {
        public static string Greet(params string[] names)
        {
            if (names[0] == null) return "Hello, my friend.";

            var lowercaseNames = SeparatorLowerCase(names);
            var uppercaseNames = SeparatorUpperCase(names);

            if (names.Length == 1)
            {
                if (uppercaseNames.Contains(names[0])) return $"HELLO, {names[0]}!";

                return $"Hello, {names[0]}.";
            }

            if (lowercaseNames.Count == 2 && uppercaseNames.Count == 0)
                return $"Hello, {lowercaseNames[0]} and {lowercaseNames[1]}.";

            if (lowercaseNames.Count > 0 && uppercaseNames.Count == 0)
            {
                var text = "Hello";

                foreach (var name in lowercaseNames) text += ", " + name;

                text = AddLastAnd(text, false);

                return text;
            }

            return "Not implemented yet";
        }

        public static string AddLastAnd(string text, bool uppercase)
        {
            var lastIndex = text.LastIndexOf(",");
            text = text.Remove(lastIndex, 1);

            if (uppercase == false)
                text = text.Insert(lastIndex, " and");
            else
                text = text.Insert(lastIndex, " AND");

            text += ".";
            return text;
        }

        public static List<string> SeparatorLowerCase(string[] names)
        {
            List<string> lowercaseNames = new();

            foreach (var name in names)
                if (!name.ToUpper().Equals(name))
                    lowercaseNames.Add(name);

            return lowercaseNames;
        }

        public static List<string> SeparatorUpperCase(string[] names)
        {
            List<string> uppercaseNames = new();

            foreach (var name in names)
                if (name.ToUpper().Equals(name))
                    uppercaseNames.Add(name);

            return uppercaseNames;
        }
    }
}