using System.IO;

namespace System.Utilities.Core.IO
{
    public static class FileExtensions
    {
        public static string GetExtension(this string input)
        {
            var extension = Path.GetExtension(input);
            return !string.IsNullOrEmpty(extension) ? extension.Remove(0, 1).ToLower() : string.Empty;
        }
    }
}
