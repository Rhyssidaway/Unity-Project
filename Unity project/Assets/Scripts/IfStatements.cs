using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public int number1 = 1;
    public int number2 = 2;

    private bool ePressed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(number1 + number2 == 2)
        {
            Debug.Log($"{number1} + {number2} = 2");
        }
        else
        {
            Debug.Log($"{number1} + {number2} doesnt = 2");
        }

        number1 = (number2 == 1) ? number2 : 2; // If (number2 == 1) then (number1 = number2) else (number1 = 2) // Short-hand if-else
    }
}
