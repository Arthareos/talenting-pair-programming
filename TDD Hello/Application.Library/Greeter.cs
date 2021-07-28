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

            List<string> lowercaseNames;
            List<string> uppercaseNames;

            return "Not implemented yet";
        }
    }
}
