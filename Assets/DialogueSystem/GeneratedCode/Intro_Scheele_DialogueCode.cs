using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Intro_Scheele_DialogueCode : DialogueCode, IDialogueCode
    {
        public Intro_Scheele_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: aa94aa22-f562-41b2-a749-b6554f617cab //
string name = "Ms. Scheele";


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Intro_Scheele_54d046ac36034db29461703b995a78f3",Intro_Scheele_54d046ac36034db29461703b995a78f3);
            eventFunctions.Add("Intro_Scheele_81952565b8444399893c335d575fa2f6",Intro_Scheele_81952565b8444399893c335d575fa2f6);
            eventFunctions.Add("Intro_Scheele_d35827a4925c43bf93352b99212b90e6",Intro_Scheele_d35827a4925c43bf93352b99212b90e6);
            eventFunctions.Add("Intro_Scheele_54b74850646345cfaa3e4978f4107d47",Intro_Scheele_54b74850646345cfaa3e4978f4107d47);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 54d046ac-3603-4db2-9461-703b995a78f3 //
        public void Intro_Scheele_54d046ac36034db29461703b995a78f3() {
GameObject.FindObjectOfType<AudioManager>().Play("Scheele 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 81952565-b844-4399-893c-335d575fa2f6 //
        public void Intro_Scheele_81952565b8444399893c335d575fa2f6() {
GameObject.FindObjectOfType<AudioManager>().Play("Scheele 1");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: d35827a4-925c-43bf-9335-2b99212b90e6 //
        public void Intro_Scheele_d35827a4925c43bf93352b99212b90e6() {
GameObject.FindObjectOfType<AudioManager>().Play("Scheele 1");
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
        }
        // Event From Node: 54b74850-6463-45cf-aa3e-4978f4107d47 //
        public void Intro_Scheele_54b74850646345cfaa3e4978f4107d47() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }

    }
}
