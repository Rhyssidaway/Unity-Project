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

    void Start()
    {
        
    }

    void Update()
    {
        interactUI.SetActive(false);
        playerDistance = Vector3.Distance(player.position, cube.position);
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
                    cubeRb.AddForce(player.forward * pushForce * 10, ForceMode.Impulse);
                }
            }
            else
            {
                ePressed = false;
            }
        }
    }
}