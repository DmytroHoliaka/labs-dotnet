namespace Json.FileManagement;

public class FileHandler
{
    public static void RemoveIfExists(string? path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}