using UnityEngine;

public class Loops : MonoBehaviour
{
    private int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
