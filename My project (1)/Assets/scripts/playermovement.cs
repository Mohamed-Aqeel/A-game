using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody Rb ;

    public float moveForward = 3000f;
    public float moveSide = 50f;
    public float moveUp = 50f;

     
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, moveForward * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            Rb.AddForce(moveSide * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            Rb.AddForce(-moveSide * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Rb.AddForce(0, moveUp* Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Rb.position.y < -5)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
