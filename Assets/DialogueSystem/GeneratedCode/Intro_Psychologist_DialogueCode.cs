using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Intro_Psychologist_DialogueCode : DialogueCode, IDialogueCode
    {
        public Intro_Psychologist_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: eb17a32d-6d31-4bf4-986e-0d05b2b9198b //
string name = "Scarlett";


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Intro_Psychologist_452b78380b8d4e55907c2cef9d7667d5",Intro_Psychologist_452b78380b8d4e55907c2cef9d7667d5);
            eventFunctions.Add("Intro_Psychologist_32642937798e4194b6cfd37157550bcd",Intro_Psychologist_32642937798e4194b6cfd37157550bcd);
            eventFunctions.Add("Intro_Psychologist_382f27c443ab4f04a64c97b6c9c8fd95",Intro_Psychologist_382f27c443ab4f04a64c97b6c9c8fd95);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 452b7838-0b8d-4e55-907c-2cef9d7667d5 //
        public void Intro_Psychologist_452b78380b8d4e55907c2cef9d7667d5() {
GameObject.FindObjectOfType<AudioManager>().Play("Scarlett 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 32642937-798e-4194-b6cf-d37157550bcd //
        public void Intro_Psychologist_32642937798e4194b6cfd37157550bcd() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }
        // Event From Node: 382f27c4-43ab-4f04-a64c-97b6c9c8fd95 //
        public void Intro_Psychologist_382f27c443ab4f04a64c97b6c9c8fd95() {
GameObject.FindObjectOfType<AudioManager>().Play("Scarlett 1");
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
        }

    }
}
