namespace PersonManagerApp;

class FileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        var readLines = File.ReadAllLines(path);
        return readLines;
    }
}