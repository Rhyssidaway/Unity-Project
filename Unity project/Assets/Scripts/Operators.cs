/* Rhys sidaway
 * 2026
 * Basic Programming
 */





using UnityEngine;

public class Operators : MonoBehaviour
{
    [Header("Variables")] // Creates a header in inspector
    public int health = 100;
    public int dmgValue = 10;

    private int bonusVal = 10;
    private int bonusMult = 2;
    private int newBonus;


    void Start()
    {
        newBonus = (bonusVal * bonusMult);
        Debug.Log("Health: " + health);
        Debug.Log("Bonus: " + bonusVal);
        Debug.Log("Bonus multiplier: " + bonusMult);
        Debug.Log("Current Bonus: " + newBonus);
        Debug.Log("New health: " + (health + newBonus));

        Debug.Log(10 + 5 * (20 / 4) - 3);
    }
}
 