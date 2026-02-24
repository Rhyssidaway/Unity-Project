using System;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Transform player;
    public Transform cube;
    public Rigidbody cubeRb;

    public int distanceNeeded;
    public GameObject interactUI;
    public float playerDistance;
    public float jumpForce = 1f;
    public float pushForce = 1f;
    private bool ePressed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = (Mathf.Sqrt(Mathf.Pow((player.transform.position.x - cube.transform.position.x), 2) + Mathf.Pow((player.transform.position.y - cube.transform.position.y), 2) + Mathf.Pow((player.transform.position.z - cube.transform.position.z), 2))); // sqrt((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2) // axis2 = player pos axis1 = cube pos
        interactUI.SetActive(false);
        if (playerDistance < distanceNeeded)
        {
            interactUI.SetActive(true);
            if (Input.GetKeyDown("e"))
            {
                ePressed = true;
                if (ePressed)
                {
                    Debug.Log("E Pressed");
                    cubeRb.AddForce(Vector3.up * jumpForce * 10, ForceMode.Impulse);
                    cubeRb.AddForce(Vector3.forward * pushForce * 10, ForceMode.Impulse);
                }
            }
            else
            {
                ePressed = false;
            }
        }
    }
}
