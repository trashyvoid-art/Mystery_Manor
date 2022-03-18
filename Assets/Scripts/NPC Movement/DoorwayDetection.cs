using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorwayDetection : MonoBehaviour
{

    private MoveNPC moveNPCscript;

    public int doorwayThreshold;
    public bool canTriggerDoorway;
    //public CapsuleCollider pColl;
    // Start is called before the first frame update
    void Start()
    {
        canTriggerDoorway = true;
        moveNPCscript = FindObjectOfType<MoveNPC>();
        //pColl = GetComponent<CapsuleCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Doorway") && canTriggerDoorway)
        {
            Debug.Log("Doorway Triggered!");
            doorwayThreshold++;
            canTriggerDoorway = false;
            StartCoroutine(DoorwayBuffer());
        }

        if (doorwayThreshold >= 3)
        {
            moveNPCscript.MoveToNextLocation();
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player" && canTriggerDoorway)
    //    {
    //        Debug.Log("Doorway Triggered!");
    //        doorwayThreshold++;
    //        canTriggerDoorway = false;
    //        StartCoroutine(DoorwayBuffer());
    //    }

    //    if (doorwayThreshold >= 3)
    //    {
    //        moveNPCscript.MoveToNextLocation();
    //    }


    //}

    IEnumerator DoorwayBuffer()
    {
        yield return new WaitForSeconds(30);
        canTriggerDoorway = true;
    }
}
