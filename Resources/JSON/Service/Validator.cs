namespace Json.Service
{
    internal class Validator
    {
        public static bool IsInt32(string? line)
        {
            if (string.IsNullOrWhiteSpace(line) == true)
            {
                return false;
            }

            return Int32.TryParse(line, out Int32 _);
        }

        public static bool IsExtensionCorrect(string? path, string? extension)
        {
            if (path is null || extension is null)
            {
                return false;
            }

            FileSystemInfo file = new FileInfo(path);

            return file.Extension.ToLower() == extension.ToLower();
        }
    }
}
