using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystem;
using DialogueSystem.Code;
using System;
using System.Text.RegularExpressions;
using System.Linq;

public class DataTracker : MonoBehaviour
{
    //public int shamsaTalkedTo = 0;
    string shamsaName = "The Astronomer";
    Notes.Journal journal = Utility.Toolbox.Instance.Journal;
    int choices = 0;
    int locationLearned = 0;

    public Astronomer_Int_DialogueCode shamsa = new Astronomer_Int_DialogueCode();
    public Sailor_Int_DialogueCode sean = new Sailor_Int_DialogueCode();
    public Ms_Scheele_Int_DialogueCode scheele = new Ms_Scheele_Int_DialogueCode();
    public Doctor_Int_DialogueCode sanchez = new Doctor_Int_DialogueCode();
    public Adventurer_Int_DialogueCode sam = new Adventurer_Int_DialogueCode();
    public Psych_Body_DialogueCode scarlette = new Psych_Body_DialogueCode();

    public int shamsaTalkedTo = 0;
    public int seanTalkedTo = 0;
    public int scheeleTalkedTo = 0;
    public int sanchezTalkedTo = 0;
    public int samTalkedTo = 0;
    public int scarletteTalkedTo = 0;

    //ShamsaTalkedTo setter
    public void setShamsaTalkedTo(int _shamsaTalkedTo)
    {
        shamsaTalkedTo = _shamsaTalkedTo;
    }

    //ShamsaTalkedTo getter
    public int getShamsaTalkedTo()
    {
        return shamsaTalkedTo;
    }


    //SeanTalkedTo setter
    public void setSeanTalkedTo(int _seanTalkedTo)
    {
        seanTalkedTo = _seanTalkedTo;
    }

    //SeanTalkedTo getter
    public int getSeanTalkedTo()
    {
        return seanTalkedTo;
    }


    //ScheeleTalkedTo setter
    public void setScheeleTalkedTo(int _scheeleTalkedTo)
    {
        scheeleTalkedTo = _scheeleTalkedTo;
    }

    //ScheeleTalkedTo getter
    public int getScheeleTalkedTo()
    {
        return scheeleTalkedTo;
    }


    //SanchezTalkedTo setter
    public void setSanchezTalkedTo(int _sanchezTalkedTo)
    {
        sanchezTalkedTo = _sanchezTalkedTo;
    }

    //SanchezTalkedTo getter
    public int getSanchezTalkedTo()
    {
        return sanchezTalkedTo;
    }


    //SamTalkedTo setter
    public void setSamTalkedTo(int _samTalkedTo)
    {
        samTalkedTo = _samTalkedTo;
    }

    //SamTalkedTo getter
    public int getSamTalkedTo()
    {
        return samTalkedTo;
    }


    //ScarletteTalkedTo setter
    public void setScarletteTalkedTo(int _scarletteTalkedTo)
    {
        scarletteTalkedTo = _scarletteTalkedTo;
    }

    //ScarletteTalkedTo getter
    public int getScarletteTalkedTo()
    {
        return scarletteTalkedTo;
    }





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}