using System.Collections.Generic;

namespace Application.Library
{
    public static class Greeter
    {
        public static string Greet(params string[] names)
        {
            // No name
            if (names[0] == null) return "Hello, my friend.";

            // Splits the names string[] into a List<string>
            var list = ManipulateVector(names);
            var lowercaseNames = SeparatorLowerCase(list);
            var uppercaseNames = SeparatorUpperCase(list);

            // Only one name
            if (names.Length == 1)
            {
                if (uppercaseNames.Contains(names[0])) return $"HELLO, {names[0]}!";

                return $"Hello, {names[0]}.";
            }

            // Only 2 lowercase names
            if (lowercaseNames.Count == 2 && uppercaseNames.Count == 0)
                return $"Hello, {lowercaseNames[0]} and {lowercaseNames[1]}.";

            // All lowercase
            if (lowercaseNames.Count > 0 && uppercaseNames.Count == 0) return AddLowercaseNames(lowercaseNames);

            // Mixed case
            if (lowercaseNames.Count > 0 && uppercaseNames.Count > 0)
                return AddLowercaseNames(lowercaseNames) + AddUppercaseNames(uppercaseNames);

            return "Not implemented yet";
        }

        public static List<string> ManipulateVector(string[] names)
        {
            List<string> list = new();

            foreach (var name in names)
            {
                if (name.Contains(","))
                {
                    var nameSplit = name.Split(", ");

                    foreach (var item in nameSplit) list.Add(item);

                    continue;
                }

                list.Add(name);
            }

            return list;
        }

        public static string AddLowercaseNames(List<string> lowercaseNames)
        {
            var text = "Hello";

            foreach (var name in lowercaseNames) text += ", " + name;

            text = AddLastAnd(text, false);

            return text;
        }

        public static string AddUppercaseNames(List<string> uppercaseNames)
        {
            var text = " AND HELLO ";

            foreach (var name in uppercaseNames) text = text + $"{name}, ";

            text = text.Remove(text.Length - 2);

            return text + "!";
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

        public static List<string> SeparatorLowerCase(List<string> names)
        {
            List<string> lowercaseNames = new();

            foreach (var name in names)
                if (!name.ToUpper().Equals(name))
                    lowercaseNames.Add(name);

            return lowercaseNames;
        }

        public static List<string> SeparatorUpperCase(List<string> names)
        {
            List<string> uppercaseNames = new();

            foreach (var name in names)
                if (name.ToUpper().Equals(name))
                    uppercaseNames.Add(name);

            return uppercaseNames;
        }
    }
}