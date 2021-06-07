using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody prb;

    public float forwardForce;

    public float sideForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        prb.AddForce(0, 0, forwardForce);
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetKey("a"))
        {
            prb.AddForce(-sideForce, 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            prb.AddForce(sideForce, 0, 0 , ForceMode.VelocityChange);
        }
        if (prb.position.y < 4f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
