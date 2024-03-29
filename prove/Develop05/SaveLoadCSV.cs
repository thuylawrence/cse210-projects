using System.Text;

class SaveLoadCSV
{
    public static void SaveToCSV(List<string> _dataToSave, string filePath)
    {
        File.WriteAllLines(filePath, _dataToSave);
    }
    public static List<string> LoadFromCSV(string _filePath)
    {
        List<string> fromCSV = new List<string>();
        StreamReader streamReader = new StreamReader(_filePath);
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            fromCSV.Add(line.ToString());
        }
        streamReader.Close();
        return fromCSV;

    }
}