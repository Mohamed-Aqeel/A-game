using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlayer : MonoBehaviour
{

    public Transform player;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0f, 0f, player.transform.position.z) + offset;
    }
}
