using System.IO;
using System.Utilities.Core.Text;

namespace System.Utilities.Core.IO
{
    public static class FileExtensions
    {
        public static string GetExtension(this string input)
        {
            var extension = Path.GetExtension(input);
            return !string.IsNullOrEmpty(extension) ? extension.Remove(0, 1).ToLower() : string.Empty;
        }

        public static string MimeType(this string input)
        {
            return FileUtils.GetMimeType(input);
        }

        public static string GenerateGuidFileName(this string input)
        {
            string extension = input.GetExtension();
            if (extension.IsNotEmpty())
            {
                return string.Format("{0}.{1}", Guid.NewGuid(), extension);
            }
            return string.Empty;
        }
    }
}
