using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Intro_Doctor_DialogueCode : DialogueCode, IDialogueCode
    {
        public Intro_Doctor_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 2e0e9d65-1dc6-4d19-8eba-14d20e96b505 //
string name = "The Doctor";


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Intro_Doctor_0b65d10a40ce4d4eb6bd6a25898c0beb",Intro_Doctor_0b65d10a40ce4d4eb6bd6a25898c0beb);
            eventFunctions.Add("Intro_Doctor_51d90005be364bdaa68cd7bfd1339973",Intro_Doctor_51d90005be364bdaa68cd7bfd1339973);
            eventFunctions.Add("Intro_Doctor_53c9f20ca47a449090658272e87ebd1d",Intro_Doctor_53c9f20ca47a449090658272e87ebd1d);
            eventFunctions.Add("Intro_Doctor_6d564ae6a1794c998104763b6fbe7926",Intro_Doctor_6d564ae6a1794c998104763b6fbe7926);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 0b65d10a-40ce-4d4e-b6bd-6a25898c0beb //
        public void Intro_Doctor_0b65d10a40ce4d4eb6bd6a25898c0beb() {
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 1");
        }
        // Event From Node: 51d90005-be36-4bda-a68c-d7bfd1339973 //
        public void Intro_Doctor_51d90005be364bdaa68cd7bfd1339973() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 2");
        }
        // Event From Node: 53c9f20c-a47a-4490-9065-8272e87ebd1d //
        public void Intro_Doctor_53c9f20ca47a449090658272e87ebd1d() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 3");
        }
        // Event From Node: 6d564ae6-a179-4c99-8104-763b6fbe7926 //
        public void Intro_Doctor_6d564ae6a1794c998104763b6fbe7926() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }

    }
}
