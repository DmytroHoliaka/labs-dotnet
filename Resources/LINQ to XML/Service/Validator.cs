namespace LINQ_to_XML.Service
{
    internal class Validator
    {
        public static bool IsInt32(string? line)
        {
            if (string.IsNullOrWhiteSpace(line) == true)
            {
                return false;
            }

            if (Int32.TryParse(line, out Int32 _) == false)
            {
                return false;
            }

            return true;
        }

        public static bool IsInRange(Int32 number, Int32 min, Int32 max)
        {
            if (number < min || number > max)
            {
                return false;
            }

            return true;
        }

        public static bool IsExtensionCorrect(string? path, string? extension)
        {
            if (path is null || extension is null)
            {
                return false;
            }

            FileSystemInfo file = new FileInfo(path);

            if (file.Extension.ToLower() != extension.ToLower())
            {
                return false;
            }

            return true;
        }
    }
}
