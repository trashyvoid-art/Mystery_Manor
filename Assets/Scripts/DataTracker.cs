using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystem;
using DialogueSystem.Code;
using System;
using System.Text.RegularExpressions;
using System.Linq;

public class DataTracker
{
    private static DataTracker _instance;
    public static DataTracker Instance 
    {
        get
        {
            if (_instance == null) 
            {
                _instance = new DataTracker();
            }
            return _instance;
        }
    }

    private DataTracker() 
    {
    
    }

    //public int shamsaTalkedTo = 0;
    //string shamsaName = "The Astronomer";
    //Notes.Journal journal = Utility.Toolbox.Instance.Journal;
    //int choices = 0;
    //int locationLearned = 0;

    //public Astronomer_Int_DialogueCode shamsa;
    //public Sailor_Int_DialogueCode sean;
    //public Ms_Scheele_Int_DialogueCode scheele;
    //public Doctor_Int_DialogueCode sanchez;
    //public Adventurer_Int_DialogueCode sam;
    //public Psych_Body_DialogueCode scarlette;

    public int shamsaTalkedTo { get; set; } = 0;
    public int seanTalkedTo { get; set; } = 0;
    public int scheeleTalkedTo { get; set; } = 0;
    public int sanchezTalkedTo { get; set; } = 0;
    public int samTalkedTo { get; set; } = 0;
    public int scarletteTalkedTo { get; set; } = 0;

    //ShamsaTalkedTo setter
    //public void setShamsaTalkedTo(int _shamsaTalkedTo)
    //{
    //    shamsaTalkedTo = _shamsaTalkedTo;
    //}

    ////ShamsaTalkedTo getter
    //public int getShamsaTalkedTo()
    //{
    //    return shamsaTalkedTo;
    //}


    ////SeanTalkedTo setter
    //public void setSeanTalkedTo(int _seanTalkedTo)
    //{
    //    seanTalkedTo = _seanTalkedTo;
    //}

    ////SeanTalkedTo getter
    //public int getSeanTalkedTo()
    //{
    //    return seanTalkedTo;
    //}


    ////ScheeleTalkedTo setter
    //public void setScheeleTalkedTo(int _scheeleTalkedTo)
    //{
    //    scheeleTalkedTo = _scheeleTalkedTo;
    //}

    ////ScheeleTalkedTo getter
    //public int getScheeleTalkedTo()
    //{
    //    return scheeleTalkedTo;
    //}


    ////SanchezTalkedTo setter
    //public void setSanchezTalkedTo(int _sanchezTalkedTo)
    //{
    //    sanchezTalkedTo = _sanchezTalkedTo;
    //}

    ////SanchezTalkedTo getter
    //public int getSanchezTalkedTo()
    //{
    //    return sanchezTalkedTo;
    //}


    ////SamTalkedTo setter
    //public void setSamTalkedTo(int _samTalkedTo)
    //{
    //    samTalkedTo = _samTalkedTo;
    //}

    ////SamTalkedTo getter
    //public int getSamTalkedTo()
    //{
    //    return samTalkedTo;
    //}


    ////ScarletteTalkedTo setter
    //public void setScarletteTalkedTo(int _scarletteTalkedTo)
    //{
    //    scarletteTalkedTo = _scarletteTalkedTo;
    //}

    ////ScarletteTalkedTo getter
    //public int getScarletteTalkedTo()
    //{
    //    return scarletteTalkedTo;
    //}





    // Start is called before the first frame update
//    void Start()
//    {
//        //shamsa = new Astronomer_Int_DialogueCode();
//        //sean = new Sailor_Int_DialogueCode();
//        //scheele = new Ms_Scheele_Int_DialogueCode();
//        //sanchez = new Doctor_Int_DialogueCode();
//        //sam = new Adventurer_Int_DialogueCode();
//        //scarlette = new Psych_Body_DialogueCode();
//}

//    // Update is called once per frame
//    void Update()
//    {

//    }
}