using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public playermovement movement;
    public Text score;
  
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle"  )
        {
            FindObjectOfType<GameManager>().GameOver();
            movement.enabled = false ;
            score.fontSize = 50;

        }
    }
}
