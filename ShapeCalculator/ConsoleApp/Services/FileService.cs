namespace ConsoleApp.Services;
public class FileService
{
    public IEnumerable<string> GetShapesFromFile(string filePath)
    {
        var returnList = new List<string>();
        try
        {
            if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
            {
                returnList = File.ReadAllLines(filePath).ToList();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return returnList;
    }
}