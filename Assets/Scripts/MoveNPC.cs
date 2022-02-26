using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{

    //public Transform scarlettePatrolRoute;
    //public List<Transform> scarletteLocations;
    //public GameObject Scarlette;
    ////public Transform scarletteLocation;
    //public int scarletteLocationIndex = 0;



    public Transform sanchezPatrolRoute;
    public List<Transform> sanchezLocations;
    public GameObject Sanchez;
    //public Transform sanchezLocation;
    public int sanchezLocationIndex = 0;



    public Transform samPatrolRoute;
    public List<Transform> samLocations;
    public GameObject Sam;
    //public Transform sanchezLocation;
    public int samLocationIndex = 0;



    public Transform seanPatrolRoute;
    public List<Transform> seanLocations;
    public GameObject Sean;
    //public Transform sanchezLocation;
    public int seanLocationIndex = 0;



    public Transform shamsaPatrolRoute;
    public List<Transform> shamsaLocations;
    public GameObject Shamsa;
    //public Transform sanchezLocation;
    public int shamsaLocationIndex = 0;



    public Transform scheelePatrolRoute;
    public List<Transform> scheeleLocations;
    public GameObject Scheele;
    //public Transform sanchezLocation;
    public int scheeleLocationIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        InitializePatrolRoute();
        MoveToNextLocation();
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
        //Move NPC to a new random location from the index

        //Scarlette
        //if (scarletteLocations.Count == 0)
        //{
        //    return;
        //}
        //scarletteLocationIndex = (scarletteLocationIndex + Random.Range(1, 7)) % scarletteLocations.Count;
        //Scarlette.transform.position = scarletteLocations[scarletteLocationIndex].position;

        //Sanchez
        if (sanchezLocations.Count == 0)
        {
            return;
        }
        sanchezLocationIndex = (sanchezLocationIndex + Random.Range(1 , 7)) % sanchezLocations.Count;
        Sanchez.transform.position = sanchezLocations[sanchezLocationIndex].position;


        //Sam
        if (samLocations.Count == 0)
        {
            return;
        }
        samLocationIndex = (samLocationIndex + Random.Range(1, 7)) % samLocations.Count;
        Sam.transform.position = samLocations[samLocationIndex].position;


        //Sean
        if (sanchezLocations.Count == 0)
        {
            return;
        }
        seanLocationIndex = (seanLocationIndex + Random.Range(1, 7)) % seanLocations.Count;
        Sean.transform.position = seanLocations[sanchezLocationIndex].position;


        //Shamsa
        if (shamsaLocations.Count == 0)
        {
            return;
        }
        shamsaLocationIndex = (shamsaLocationIndex + Random.Range(1, 7)) % shamsaLocations.Count;
        Shamsa.transform.position = shamsaLocations[shamsaLocationIndex].position;


        //Scheele
        if (scheeleLocations.Count == 0)
        {
            return;
        }
        scheeleLocationIndex = (scheeleLocationIndex + Random.Range(1, 7)) % scheeleLocations.Count;
        Scheele.transform.position = scheeleLocations[scheeleLocationIndex].position;

        StartCoroutine(MoveInterval());
    }

    IEnumerator MoveInterval()
    {
        yield return new WaitForSeconds(60);
        MoveToNextLocation();
    }
}
