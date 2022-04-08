using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    private DoorwayDetection doorwayDetectionScript;


    public int randomMoveOrder;
    public int doorwayThreshold;
    public bool canTriggerDoorway;

    //public GameObject Player;
    //public CapsuleCollider pColl;// = Player.GetComponent<CapsuleCollider>();

    
       


    //public GameObject ThreshholdMat;

    //Scarlette data (Dead in episode 1)

    //public Transform scarlettePatrolRoute;
    //public List<Transform> scarletteLocations;
    //public GameObject Scarlette;
    ////public Transform scarletteLocation;
    //public int scarletteLocationIndex = 0;


    //Sanchez data
    public Transform sanchezPatrolRoute;
    public List<Transform> sanchezLocations;
    public GameObject Sanchez;
    //public Transform sanchezLocation;
    public int sanchezLocationIndex = 0;


    //Sam data
    public Transform samPatrolRoute;
    public List<Transform> samLocations;
    public GameObject Sam;
    //public Transform sanchezLocation;
    public int samLocationIndex = 0;


    //Sean data
    public Transform seanPatrolRoute;
    public List<Transform> seanLocations;
    public GameObject Sean;
    //public Transform sanchezLocation;
    public int seanLocationIndex = 0;


    //Shamsa data
    public Transform shamsaPatrolRoute;
    public List<Transform> shamsaLocations;
    public GameObject Shamsa;
    //public Transform sanchezLocation;
    public int shamsaLocationIndex = 0;


    //Scheele data
    public Transform scheelePatrolRoute;
    public List<Transform> scheeleLocations;
    public GameObject Scheele;
    //public Transform sanchezLocation;
    public int scheeleLocationIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        doorwayDetectionScript = GetComponent<DoorwayDetection>();
        //pColl = Player.GetComponent<CapsuleCollider>();
        InitializePatrolRoute();
        //StartCoroutine(MoveInterval());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InitializePatrolRoute()
    {
        //Adds transform positions to each locations list for each patrol route

        //Scarlette
        //foreach (Transform child in scarlettePatrolRoute)
        //{
        //    scarletteLocations.Add(child);
        //}

        //Sanchez
        foreach (Transform child in sanchezPatrolRoute)
        {
            sanchezLocations.Add(child);
        }

        //Sam
        foreach (Transform child in samPatrolRoute)
        {
            samLocations.Add(child);
        }

        //Sean
        foreach (Transform child in seanPatrolRoute)
        {
            seanLocations.Add(child);
        }

        //Shamsa
        foreach (Transform child in shamsaPatrolRoute)
        {
            shamsaLocations.Add(child);
        }

        //Scheele
        foreach (Transform child in scheelePatrolRoute)
        {
            scheeleLocations.Add(child);
        }
    }

    public void MoveToNextLocation()
    {
        randomMoveOrder = Random.Range(1, 7);


        //Move NPC to a new random location from the index

        //Scarlette
        //if (scarletteLocations.Count == 0)
        //{
        //    return;
        //}
        //scarletteLocationIndex = (scarletteLocationIndex + 1) % scarletteLocations.Count;
        //Scarlette.transform.position = scarletteLocations[scarletteLocationIndex].position;

        //Sanchez
        if (sanchezLocations.Count == 0)
        {
            return;
        }
        sanchezLocationIndex = (sanchezLocationIndex + randomMoveOrder) % sanchezLocations.Count;
        Sanchez.transform.position = sanchezLocations[sanchezLocationIndex].position;


        //Sam
        if (samLocations.Count == 0)
        {
            return;
        }
        samLocationIndex = (samLocationIndex + randomMoveOrder) % samLocations.Count;
        Sam.transform.position = samLocations[samLocationIndex].position;


        //Sean
        if (sanchezLocations.Count == 0)
        {
            return;
        }
        seanLocationIndex = (seanLocationIndex + randomMoveOrder) % seanLocations.Count;
        Sean.transform.position = seanLocations[sanchezLocationIndex].position;


        //Shamsa
        if (shamsaLocations.Count == 0)
        {
            return;
        }
        shamsaLocationIndex = (shamsaLocationIndex + randomMoveOrder) % shamsaLocations.Count;
        Shamsa.transform.position = shamsaLocations[shamsaLocationIndex].position;


        //Scheele
        if (scheeleLocations.Count == 0)
        {
            return;
        }
        scheeleLocationIndex = (scheeleLocationIndex + randomMoveOrder) % scheeleLocations.Count;
        Scheele.transform.position = scheeleLocations[scheeleLocationIndex].position;

        //StartCoroutine(MoveInterval());
    }


    //old code that causes characters to move once every 2 minutes COMMENTED OUT FOR NOW
    //IEnumerator MoveInterval()
    //{
    //    yield return new WaitForSeconds(120);
    //    MoveToNextLocation();
    //}




    



    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Doorway" && canTriggerDoorway)
    //    {
    //        Debug.Log("Doorway triggered");
    //        doorwayThreshold++;
    //        canTriggerDoorway = false;
    //        StartCoroutine(DoorwayBuffer());
    //    }
        
    //    if (doorwayThreshold >= 3)
    //    {
    //        MoveToNextLocation();
    //    }

    //}

    //30 second buffer time between being able to trigger a doorway
    //IEnumerator DoorwayBuffer()
    //{
    //    yield return new WaitForSeconds(30);
    //    canTriggerDoorway = true;
    //}
}