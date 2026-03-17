using UnityEngine;
using System.IO;

public class FileManager : MonoBehaviour
{
    public string textFileName;                  // This is the file name
    public string[] textFileContents;            // This array will store the file contents

    void Start()
    {
        CreateNewTextFile("PlayerData");
    }

    public void CreateNewTextFile(string textFileName)
    {
        // Create a file path string for the full path on that specific computer
        string directoryPath = Application.dataPath + "/DataFiles/" + textFileName + ".txt";

        // Check if the path exists
        // If not then create the folder
        if (File.Exists(directoryPath) == false)
        {
            // Doesnt exist so create it
            Directory.CreateDirectory(Application.dataPath + "/DataFiles");

            // Create the file with the name of the file as the first line
            File.WriteAllText(directoryPath, textFileName + '\n');
                

        }
    }

}
