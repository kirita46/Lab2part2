using System.Linq;

namespace LAb2
{
    public static class Extensions
    {
        public static string AddCommas(this string input)
        {
            return string.Join(", ", input.Split(' '));
        }

        public static Set<T> RemoveDuplicates<T>(this Set<T> set)
        {
            return new Set<T>(set.Distinct<T>());
        }
    }
}