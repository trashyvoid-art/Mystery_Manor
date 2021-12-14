using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Sailor_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Sailor_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 0f54fb55-3b6d-464f-804b-3ccde1a544b9 //
string name ="The Sailor";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Sailor_Int_c42606c928224d3f81dc95e64c51df83_bbd35785715d435c885cfc38f9b0e621",Sailor_Int_c42606c928224d3f81dc95e64c51df83_bbd35785715d435c885cfc38f9b0e621);
            dialogueChecks.Add("Sailor_Int_7f15a5bb91e14f689f20ec5bd165208a_f6d08e29b0a64bd29e1339f35cc078e6",Sailor_Int_7f15a5bb91e14f689f20ec5bd165208a_f6d08e29b0a64bd29e1339f35cc078e6);
            dialogueChecks.Add("Sailor_Int_678bbf2fcbc54df7aee28844283ff0c7_09f010da402b4c1ab289489f8c0c161f",Sailor_Int_678bbf2fcbc54df7aee28844283ff0c7_09f010da402b4c1ab289489f8c0c161f);
            dialogueChecks.Add("Sailor_Int_7f9a441fd3be4ed1a2e0ed6722d90f15_6309bf4edfd14419990846211b80ec38",Sailor_Int_7f9a441fd3be4ed1a2e0ed6722d90f15_6309bf4edfd14419990846211b80ec38);
            dialogueChecks.Add("Sailor_Int_7f9a441fd3be4ed1a2e0ed6722d90f15_73aa9ac7cce94522a9adc98e06f60fa1",Sailor_Int_7f9a441fd3be4ed1a2e0ed6722d90f15_73aa9ac7cce94522a9adc98e06f60fa1);
            dialogueChecks.Add("Sailor_Int_2b152aca0405458fa743558ef9807907_f5db412e40eb44169a30d867480231b8",Sailor_Int_2b152aca0405458fa743558ef9807907_f5db412e40eb44169a30d867480231b8);
            dialogueChecks.Add("Sailor_Int_2b152aca0405458fa743558ef9807907_5dfaf0ceba0542f1bd3fe4796bf138cc",Sailor_Int_2b152aca0405458fa743558ef9807907_5dfaf0ceba0542f1bd3fe4796bf138cc);
            dialogueChecks.Add("Sailor_Int_98718d3e358044299304317d740c836f_bf8b108b5976456ca3b730f6cefaa834",Sailor_Int_98718d3e358044299304317d740c836f_bf8b108b5976456ca3b730f6cefaa834);
            dialogueChecks.Add("Sailor_Int_5b3d4a4be47c4ee2843301caddf24e8c_e0ac6070b01b4257aec638ce45fd5b32",Sailor_Int_5b3d4a4be47c4ee2843301caddf24e8c_e0ac6070b01b4257aec638ce45fd5b32);
            dialogueChecks.Add("Sailor_Int_5b3d4a4be47c4ee2843301caddf24e8c_2aceea68666043ae863d2a4f85a79236",Sailor_Int_5b3d4a4be47c4ee2843301caddf24e8c_2aceea68666043ae863d2a4f85a79236);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575);
            eventFunctions.Add("Sailor_Int_80b8a9656ebf435994de754b7e064f63",Sailor_Int_80b8a9656ebf435994de754b7e064f63);
            dialogueChecks.Add("Sailor_Int_fd27352cfbb24c77ae94944e4e0c230f_50e2bbf9f332429684035e44e74c2e19",Sailor_Int_fd27352cfbb24c77ae94944e4e0c230f_50e2bbf9f332429684035e44e74c2e19);
            eventFunctions.Add("Sailor_Int_2a4a160e8807452187737ce40621ddc2",Sailor_Int_2a4a160e8807452187737ce40621ddc2);
            eventFunctions.Add("Sailor_Int_44d925b7fa1d404c8a6b1d13b4bcfd6d",Sailor_Int_44d925b7fa1d404c8a6b1d13b4bcfd6d);
            dialogueChecks.Add("Sailor_Int_5afeabc0952e4207961e319629698b01_48ddfab5a69b41a7a39b72b8a104c925",Sailor_Int_5afeabc0952e4207961e319629698b01_48ddfab5a69b41a7a39b72b8a104c925);
            eventFunctions.Add("Sailor_Int_f1276cae92714b0fa9d99b0e9f87a9c0",Sailor_Int_f1276cae92714b0fa9d99b0e9f87a9c0);
            eventFunctions.Add("Sailor_Int_df837cb66fd143fb8b023ebdd39ca6a4",Sailor_Int_df837cb66fd143fb8b023ebdd39ca6a4);

        }

        // Dialogue Checks //
        // From Node: c42606c9-2822-4d3f-81dc-95e64c51df83 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - bbd35785-715d-435c-885c-fc38f9b0e621 //
        public bool Sailor_Int_c42606c928224d3f81dc95e64c51df83_bbd35785715d435c885cfc38f9b0e621()
        {
            return (true);
        }
        // From Node: 7f15a5bb-91e1-4f68-9f20-ec5bd165208a //
        // Choice: Do you have any other information about the case? - f6d08e29-b0a6-4bd2-9e13-39f35cc078e6 //
        public bool Sailor_Int_7f15a5bb91e14f689f20ec5bd165208a_f6d08e29b0a64bd29e1339f35cc078e6()
        {
            return (true);
        }
        // From Node: 678bbf2f-cbc5-4df7-aee2-8844283ff0c7 //
        // Choice: Where were you at the time of the murder? - 09f010da-402b-4c1a-b289-489f8c0c161f //
        public bool Sailor_Int_678bbf2fcbc54df7aee28844283ff0c7_09f010da402b4c1ab289489f8c0c161f()
        {
            return (true);
        }
        // From Node: 7f9a441f-d3be-4ed1-a2e0-ed6722d90f15 //
        // Choice: Where were you at the time of the murder? - 6309bf4e-dfd1-4419-9908-46211b80ec38 //
        public bool Sailor_Int_7f9a441fd3be4ed1a2e0ed6722d90f15_6309bf4edfd14419990846211b80ec38()
        {
            return (true);
        }
        // From Node: 7f9a441f-d3be-4ed1-a2e0-ed6722d90f15 //
        // Choice: Do you have any other information about the case? - 73aa9ac7-cce9-4522-a9ad-c98e06f60fa1 //
        public bool Sailor_Int_7f9a441fd3be4ed1a2e0ed6722d90f15_73aa9ac7cce94522a9adc98e06f60fa1()
        {
            return (true);
        }
        // From Node: 2b152aca-0405-458f-a743-558ef9807907 //
        // Choice: Where were you at the time of the murder? - f5db412e-40eb-4416-9a30-d867480231b8 //
        public bool Sailor_Int_2b152aca0405458fa743558ef9807907_f5db412e40eb44169a30d867480231b8()
        {
            return (true);
        }
        // From Node: 2b152aca-0405-458f-a743-558ef9807907 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 5dfaf0ce-ba05-42f1-bd3f-e4796bf138cc //
        public bool Sailor_Int_2b152aca0405458fa743558ef9807907_5dfaf0ceba0542f1bd3fe4796bf138cc()
        {
            return (true);
        }
        // From Node: 98718d3e-3580-4429-9304-317d740c836f //
        // Choice: Do you know why someone would have wanted to hurt the victim? - bf8b108b-5976-456c-a3b7-30f6cefaa834 //
        public bool Sailor_Int_98718d3e358044299304317d740c836f_bf8b108b5976456ca3b730f6cefaa834()
        {
            return (true);
        }
        // From Node: 5b3d4a4b-e47c-4ee2-8433-01caddf24e8c //
        // Choice: Do you know why someone would have wanted to hurt the victim? - e0ac6070-b01b-4257-aec6-38ce45fd5b32 //
        public bool Sailor_Int_5b3d4a4be47c4ee2843301caddf24e8c_e0ac6070b01b4257aec638ce45fd5b32()
        {
            return (true);
        }
        // From Node: 5b3d4a4b-e47c-4ee2-8433-01caddf24e8c //
        // Choice: Do you have any other information about the case? - 2aceea68-6660-43ae-863d-2a4f85a79236 //
        public bool Sailor_Int_5b3d4a4be47c4ee2843301caddf24e8c_2aceea68666043ae863d2a4f85a79236()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Where were you at the time of the murder? - 57059fe8-7b99-468c-8f9b-3dc22aca7f0b //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 3965af18-3957-4a8f-92ce-52f0d9e94ce0 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Do you have any other information about the case? - 85f8aec8-8713-42de-94f2-b01aab097575 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575()
        {
            return (true);
        }
        // From Node: fd27352c-fbb2-4c77-ae94-944e4e0c230f //
        // Choice: Do you have any other information about the case? - 50e2bbf9-f332-4296-8403-5e44e74c2e19 //
        public bool Sailor_Int_fd27352cfbb24c77ae94944e4e0c230f_50e2bbf9f332429684035e44e74c2e19()
        {
            return (true);
        }
        // From Node: 5afeabc0-952e-4207-961e-319629698b01 //
        // Choice: Where were you at the time of the murder? - 48ddfab5-a69b-41a7-a39b-72b8a104c925 //
        public bool Sailor_Int_5afeabc0952e4207961e319629698b01_48ddfab5a69b41a7a39b72b8a104c925()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: 80b8a965-6ebf-4359-94de-754b7e064f63 //
        public void Sailor_Int_80b8a9656ebf435994de754b7e064f63() {
journal.AddEntry("The Sailor was in the Observatory.");
        }
        // Event From Node: 2a4a160e-8807-4521-8773-7ce40621ddc2 //
        public void Sailor_Int_2a4a160e8807452187737ce40621ddc2() {
journal.AddEntry("The Sailor was in the Observatory.");
        }
        // Event From Node: 44d925b7-fa1d-404c-8a6b-1d13b4bcfd6d //
        public void Sailor_Int_44d925b7fa1d404c8a6b1d13b4bcfd6d() {
journal.AddEntry("The Sailor was in the Observatory.");
        }
        // Event From Node: f1276cae-9271-4b0f-a9d9-9b0e9f87a9c0 //
        public void Sailor_Int_f1276cae92714b0fa9d99b0e9f87a9c0() {
journal.AddEntry("The Sailor was in the Observatory.");
        }
        // Event From Node: df837cb6-6fd1-43fb-8b02-3ebdd39ca6a4 //
        public void Sailor_Int_df837cb66fd143fb8b023ebdd39ca6a4() {
journal.AddEntry("The Sailor was in the Observatory.");
        }

    }
}
