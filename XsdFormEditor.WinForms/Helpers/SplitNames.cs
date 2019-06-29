using System.Linq;

static class SplitNames
{
    public static string ToReadable(this string Input)
    {
         return string.IsNullOrEmpty(Input) ? Input : new string(Input.SelectMany((c, i) => (i > 0 && char.IsUpper(c)) ? new[] { ' ', c } : new[] { c }).ToArray());
    }
}
