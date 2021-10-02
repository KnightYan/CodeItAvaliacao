
namespace CodeItAirlines.Comuns.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            if (str == null)
                return true;
            return string.IsNullOrEmpty(str.Trim());
        }

        public static bool IsNullOrWhiteSpaceOrSpecialFeatures(this string str)
        {
            if (str == null)
                return true;

            var strAux = str.Replace('\n', ' ');
            strAux = strAux.Replace('\t', ' ');
            strAux = strAux.Replace('\r', ' ');

            return string.IsNullOrWhiteSpace(strAux);
        }
    }
}
