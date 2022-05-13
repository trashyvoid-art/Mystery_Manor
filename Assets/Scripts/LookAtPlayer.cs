using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public GameObject[] respawns;

    public Transform playerPos;
    public Transform lookAtPos;


    // Start is called before the first frame update
    void Start()
    {
        lookAtPos = playerPos;
}

    // Update is called once per frame
    void Update()
    {
        if (playerPos != null)
        {
            transform.LookAt(playerPos);
        }
        
    }
}
