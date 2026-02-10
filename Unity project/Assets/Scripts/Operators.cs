/* Rhys sidaway
 * 2026
 * Basic Programming
 */





using UnityEngine;

public class Operators : MonoBehaviour
{
    public int health = 100;
    public int dmgValue = 10;
    private int medpack = 5;

    

    void Start()
    {
        Debug.Log("Health: " + health);
        Debug.Log("Damage: " + dmgValue);
        Debug.Log("Medpack: " + medpack);
    }
}
