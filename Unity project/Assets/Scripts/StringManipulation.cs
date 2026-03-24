using UnityEngine;

public class StringManipulation : MonoBehaviour
{
    public string aName = "Picard";     // Can store a word or sentence
    char targetLetter = 'a';                 // Can only store a single character
    char anotherCharacter = 'A';        // Case sensitive; 'A' is not the same as 'a'




    void Start()
    {
        foreach(char letter in aName)
        {
            Debug.Log(letter);

            if (letter == targetLetter)
            {
                Debug.Log("Target letter found");
                break;
            }
            else
            {
                Debug.Log("Its not a match");
            }
        }




    } // End of start function
} // End of StringManipulation Class
