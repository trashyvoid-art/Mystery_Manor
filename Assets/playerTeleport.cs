using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleport : MonoBehaviour
{
    public GameObject spawn;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown("e"))
        {
            player.transform.position = spawn.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Teleport");
        }
    }
}
