using UnityEngine;
public class Functions : MonoBehaviour
{
    public int myHealth = 100;
    public int myDamage = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisplayHealth(); // 100

        myHealth = myHealth + 10; // Adding 10 to my health

        DisplayHealth(); // 110

        myHealth += 10; // Adding 10 to my health

        DisplayHealth(); // 120
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayHealth()
    {
        Debug.Log("My current Health is: " + myHealth);
    }
    
}
