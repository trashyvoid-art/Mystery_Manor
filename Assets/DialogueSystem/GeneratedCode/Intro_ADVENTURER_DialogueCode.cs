using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Intro_ADVENTURER_DialogueCode : DialogueCode, IDialogueCode
    {
        public Intro_ADVENTURER_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: f8a94eb7-4b4f-40a5-a77d-30ca2f55c6ca //
string name = "THE ADVENTURER";


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Intro_ADVENTURER_3d2df224c2264df1812ce8db3e62f738",Intro_ADVENTURER_3d2df224c2264df1812ce8db3e62f738);
            eventFunctions.Add("Intro_ADVENTURER_99075cafcdf943e1b73e877747e19171",Intro_ADVENTURER_99075cafcdf943e1b73e877747e19171);
            eventFunctions.Add("Intro_ADVENTURER_d371bd72db124c43a72faeb05d270123",Intro_ADVENTURER_d371bd72db124c43a72faeb05d270123);
            eventFunctions.Add("Intro_ADVENTURER_fff6e1b2af38404a82bd9395a88ca23b",Intro_ADVENTURER_fff6e1b2af38404a82bd9395a88ca23b);
            eventFunctions.Add("Intro_ADVENTURER_d743c602348d4644be8f6fd5f2624522",Intro_ADVENTURER_d743c602348d4644be8f6fd5f2624522);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 3d2df224-c226-4df1-812c-e8db3e62f738 //
        public void Intro_ADVENTURER_3d2df224c2264df1812ce8db3e62f738() {
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
GameObject.FindObjectOfType<AudioManager>().Play("Sam 1");
        }
        // Event From Node: 99075caf-cdf9-43e1-b73e-877747e19171 //
        public void Intro_ADVENTURER_99075cafcdf943e1b73e877747e19171() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sam 2");
        }
        // Event From Node: d371bd72-db12-4c43-a72f-aeb05d270123 //
        public void Intro_ADVENTURER_d371bd72db124c43a72faeb05d270123() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sam 3");
        }
        // Event From Node: fff6e1b2-af38-404a-82bd-9395a88ca23b //
        public void Intro_ADVENTURER_fff6e1b2af38404a82bd9395a88ca23b() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sam 4");
        }
        // Event From Node: d743c602-348d-4644-be8f-6fd5f2624522 //
        public void Intro_ADVENTURER_d743c602348d4644be8f6fd5f2624522() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }

    }
}
