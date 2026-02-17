using UnityEngine;
public class Functions : MonoBehaviour
{
    public int myHealth = 100;
    public int myDamage = 10;
    private float random;
    private int newNumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        random += RandomNumber();

        DisplayHealth(); // 100

        myHealth = myHealth + 10; // Adding 10 to my health

        DisplayHealth(); // 110

        myHealth += 10; // Adding 10 to my health

        DisplayHealth(); // 120

        Debug.Log("Random Number: " + random);

        SayHello();

        newNumber = GiveMeANumber(); // Assigns 100 to newNumber

        newNumber = Add(10, 40); // Assigns 10 + 40
        Debug.Log("10 + 40 = " + newNumber);

        newNumber = Subtract(newNumber, 10); // Subtracts 10 from 50
        Debug.Log("50 - 10 = " + newNumber);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayHealth()
    {
        Debug.Log("My current Health is: " + myHealth);
    }

    public float RandomNumber()
    {
        return Random.value;
    }

    public void SayHello() // 'Says Hello!'
    {
        Debug.Log("Hello!");
    }
    public int GiveMeANumber() // Returns 100 as integer
    {
        return 20 + 80;
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    /// <summary>
    /// Subtracts the Smaller number from the Bigger number
    /// </summary>
    /// <param name="a"> Bigger Number </param>
    /// <param name="b"> Smaller Number</param>
    /// <returns></returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
