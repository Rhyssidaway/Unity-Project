using UnityEngine;
using System.IO;
using System.Linq;

public class FileManager : MonoBehaviour
{
    public string textFileName;                  // This is the file name
    public string[] textFileContents;            // This array will store the file contents
    private string directoryName;                // The name of the directory the file will be created/Written/Read from
    private string csvFileName;

    void Start()
    {
        textFileName = "playerData.txt";
        csvFileName = "PLAYERDATA.csv";
        directoryName = "/" + "DataFiles" + "/";
        CreateNewTextFile(textFileName);

        textFileContents = ReadTextFileContents(textFileName);

        CreateNewCsvFile(csvFileName);

        ReadCSV(csvFileName);
    }


    /// <summary>
    /// Creates a new Text file at a location if it doesnt already exist. Has input string textFileName.
    /// </summary>
    /// <param name="textFileName"></param>
    public void CreateNewTextFile(string textFileName)
    {
        // Create a file path string for the full path on that specific computer
        string directoryPath = Application.dataPath + directoryName + textFileName;

        // Check if the path exists
        // If not then create the folder
        if (!File.Exists(directoryPath))
        {
            // Doesnt exist so create it
            Directory.CreateDirectory(Application.dataPath + directoryName);

            // Create the file with the name of the file as the first line
            File.WriteAllText(directoryPath, textFileName + '\n');
        }
    }

    public void WriteToFile(string filename, string data)
    {
        string directoryPath = Application.dataPath + directoryName + filename;

        // Check if file exists
        if (File.Exists(directoryPath))
        {
            File.AppendAllText(directoryPath, data + "\n");
        }
       
    }


    /// <summary>
    /// Reads all file contents and returns them in an array. Needs input string filename
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    public string[] ReadTextFileContents(string filename)
    {
        string directoryPath = Application.dataPath + directoryName + filename;
        string[] textContents = new string[1];

        // Check if file exists
        if(File.Exists(directoryPath)) 
        {
            textContents = File.ReadAllLines(directoryPath);
        }

        return textContents;
    }

    public void CreateNewCsvFile(string filename)
    {
        // Takes a filename 
        // Check if it exists
        // If not then create it

        string directoryPath = Application.dataPath + directoryName;
        string filePath = directoryPath + filename;

        // Check if the folder exists if not then create it
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);

        }

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "Name,Level\n");
            Debug.Log($"CSV file created with headers: Name, Level at {filePath}.");
        }
    }
    public void ReadCSV(string filename)
    {
        string filepath = Application.dataPath + directoryName + filename;

        if (File.Exists(filepath))
        {
            string[] lines = File.ReadAllLines(filepath);

            // Seperate each line using the comma as a serperator to get each value/word
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');

                if(values.Length == 2 && int.TryParse(values[1], out int level))
                {
                    Debug.Log("Name: " + values[0] + " Level: " + values[1]);
                }
                else
                {
                    Debug.LogError("Invlaid CSV format at " + (i + 1) + ": " + values[i]);
                }
            }
        }
        else
        {
            Debug.LogError("File not found: " + filepath);
        }
    }

}
