using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Intro_Astronomer_DialogueCode : DialogueCode, IDialogueCode
    {
        public Intro_Astronomer_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: ff09bfbf-f32a-4fa3-b2a3-22bd25406348 //
string name = "The Astronomer";


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Intro_Astronomer_cb71d749e7e14080b8858ff7dac18641",Intro_Astronomer_cb71d749e7e14080b8858ff7dac18641);
            eventFunctions.Add("Intro_Astronomer_af12d1b62da348189a52a1d269244072",Intro_Astronomer_af12d1b62da348189a52a1d269244072);
            eventFunctions.Add("Intro_Astronomer_0f5ee9b7d67b458c9ccb915450bbb4b6",Intro_Astronomer_0f5ee9b7d67b458c9ccb915450bbb4b6);
            eventFunctions.Add("Intro_Astronomer_51c3b123755d40b68ce05901697d9861",Intro_Astronomer_51c3b123755d40b68ce05901697d9861);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: cb71d749-e7e1-4080-b885-8ff7dac18641 //
        public void Intro_Astronomer_cb71d749e7e14080b8858ff7dac18641() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa 1");
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
        }
        // Event From Node: af12d1b6-2da3-4818-9a52-a1d269244072 //
        public void Intro_Astronomer_af12d1b62da348189a52a1d269244072() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 0f5ee9b7-d67b-458c-9ccb-915450bbb4b6 //
        public void Intro_Astronomer_0f5ee9b7d67b458c9ccb915450bbb4b6() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa 3");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 51c3b123-755d-40b6-8ce0-5901697d9861 //
        public void Intro_Astronomer_51c3b123755d40b68ce05901697d9861() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }

    }
}
