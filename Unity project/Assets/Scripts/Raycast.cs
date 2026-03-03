using UnityEditor.Build.Reporting;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [Header("Interation Variables")]
    public Transform player;
    public Transform cube;
    public Rigidbody cubeRb;

    public int distanceNeeded;
    public GameObject interactUI;
    public float playerDistance;
    public float jumpForce = 1f;
    public float pushForce = 1f;
    private bool ePressed = false;

    [Header("Raycast Variables")]
    LayerMask layerMask;
    public Material red;
    public Material green;

    void Awake()
    {
        layerMask = LayerMask.GetMask("Wall", "Character");
    }

    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void Update()
    {
        interactUI.SetActive(false);
        playerDistance = Vector3.Distance(player.position, cube.position);
        if (playerDistance < distanceNeeded)
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, (float)distanceNeeded, layerMask))
            {
                interactUI.SetActive(true);
                cube.GetComponent<Renderer>().material = red;
                if (Input.GetKeyDown("e"))
                {
                    ePressed = true;
                    if (ePressed)
                    {
                        cubeRb.AddForce(Vector3.up * jumpForce * 10, ForceMode.Impulse);
                        cubeRb.AddForce(player.forward * pushForce * 10, ForceMode.Impulse);
                    }
                }
                else
                {
                    ePressed = false;
                }
            }
            else
            {
                cube.GetComponent<Renderer>().material = green;
            }
        }
        else
        {
            cube.GetComponent<Renderer>().material = green;
        }
    }
}