using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Astronomer_Int_DialogueCode : IDialogueCode
    {
        private Dictionary<string, IDialogueCode.EventDelegate> eventFunctions = new Dictionary<string, IDialogueCode.EventDelegate>();
        private Dictionary<string, IDialogueCode.ConditionDelegate> conditionChecks = new Dictionary<string, IDialogueCode.ConditionDelegate>();
        private Dictionary<string, IDialogueCode.ConditionDelegate> dialogueChecks = new Dictionary<string, IDialogueCode.ConditionDelegate>();
        public Dictionary<string, IDialogueCode.EventDelegate> EventFunctions => eventFunctions;
        public Dictionary<string, IDialogueCode.ConditionDelegate> ConditionChecks => conditionChecks;
        public Dictionary<string, IDialogueCode.ConditionDelegate> DialogueChecks => dialogueChecks;
        public string GetVariable(string variableName) {
            return this.GetType().GetField(variableName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(this).ToString(); 
        }
        public Astronomer_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 116917f5-2d17-47f4-8030-76c6415234cb //
string name = "The Astronomer";


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c0ae49f899c8414b8c81943b1c45082b",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c0ae49f899c8414b8c81943b1c45082b);
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c7afa89ba4d04601b5270254eafba349",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c7afa89ba4d04601b5270254eafba349);
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_571adf63a14c406898fdd5b55270f405",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_571adf63a14c406898fdd5b55270f405);
            dialogueChecks.Add("Astronomer_Int_d315e8a9d9e142e9901c0722899985b1_ff64903ae9c645e9b158657315bcd344",Astronomer_Int_d315e8a9d9e142e9901c0722899985b1_ff64903ae9c645e9b158657315bcd344);
            dialogueChecks.Add("Astronomer_Int_d315e8a9d9e142e9901c0722899985b1_1f7c990098a0419885c084257b9abd37",Astronomer_Int_d315e8a9d9e142e9901c0722899985b1_1f7c990098a0419885c084257b9abd37);
            dialogueChecks.Add("Astronomer_Int_245fb1efbe3247a5b6e493b0bc50d57c_3e09c6d3041845be8ea86ce8f4a1542d",Astronomer_Int_245fb1efbe3247a5b6e493b0bc50d57c_3e09c6d3041845be8ea86ce8f4a1542d);
            dialogueChecks.Add("Astronomer_Int_9a783efbad3944818b8505a620a1b3ed_7e081b1faf5f4ccb886d7cd89be637b6",Astronomer_Int_9a783efbad3944818b8505a620a1b3ed_7e081b1faf5f4ccb886d7cd89be637b6);
            dialogueChecks.Add("Astronomer_Int_ceea2aee08554bcba05ab5466a8286ef_318fe419eede48b8b015fac356bca549",Astronomer_Int_ceea2aee08554bcba05ab5466a8286ef_318fe419eede48b8b015fac356bca549);
            dialogueChecks.Add("Astronomer_Int_ceea2aee08554bcba05ab5466a8286ef_c793fca2bc504935b04a0133a00836b2",Astronomer_Int_ceea2aee08554bcba05ab5466a8286ef_c793fca2bc504935b04a0133a00836b2);
            dialogueChecks.Add("Astronomer_Int_06dd7460095446c89485fb594e0878dc_3a3e9a8a27d643309f6c64d32e4e619d",Astronomer_Int_06dd7460095446c89485fb594e0878dc_3a3e9a8a27d643309f6c64d32e4e619d);
            dialogueChecks.Add("Astronomer_Int_b1c793f8e2cb46edbf2f4ad9c50c0b94_a6519480def845308d4faeed05219492",Astronomer_Int_b1c793f8e2cb46edbf2f4ad9c50c0b94_a6519480def845308d4faeed05219492);
            dialogueChecks.Add("Astronomer_Int_0611dee78668445cb32dd273d9354c40_db52a2827eb94440bd37f2db5df6c8ae",Astronomer_Int_0611dee78668445cb32dd273d9354c40_db52a2827eb94440bd37f2db5df6c8ae);
            dialogueChecks.Add("Astronomer_Int_922c28f36d5040b995bb50f6b98a7fa9_2c9ffe4d4b4f46239a70a0534d03dcc0",Astronomer_Int_922c28f36d5040b995bb50f6b98a7fa9_2c9ffe4d4b4f46239a70a0534d03dcc0);
            dialogueChecks.Add("Astronomer_Int_173dfcd7b7d04e2d8971a05afb3d9cdd_7a719a84ec6741e88f4c1d44e9b48410",Astronomer_Int_173dfcd7b7d04e2d8971a05afb3d9cdd_7a719a84ec6741e88f4c1d44e9b48410);
            dialogueChecks.Add("Astronomer_Int_173dfcd7b7d04e2d8971a05afb3d9cdd_daf755e192df4ac297fcbbb7991681be",Astronomer_Int_173dfcd7b7d04e2d8971a05afb3d9cdd_daf755e192df4ac297fcbbb7991681be);

        }

        // Dialogue Checks //
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Where were you at the time of the murder? - c0ae49f8-99c8-414b-8c81-943b1c45082b //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c0ae49f899c8414b8c81943b1c45082b()
        {
            return (true);
        }
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Do you know why someone would have wanted to hurt the victim? - c7afa89b-a4d0-4601-b527-0254eafba349 //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c7afa89ba4d04601b5270254eafba349()
        {
            return (true);
        }
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Do you have any other information about the case?

 - 571adf63-a14c-4068-98fd-d5b55270f405 //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_571adf63a14c406898fdd5b55270f405()
        {
            return (true);
        }
        // From Node: d315e8a9-d9e1-42e9-901c-0722899985b1 //
        // Choice: Where were you at the time of the murder? - ff64903a-e9c6-45e9-b158-657315bcd344 //
        public bool Astronomer_Int_d315e8a9d9e142e9901c0722899985b1_ff64903ae9c645e9b158657315bcd344()
        {
            return (true);
        }
        // From Node: d315e8a9-d9e1-42e9-901c-0722899985b1 //
        // Choice: Do you have any other information about the case?

 - 1f7c9900-98a0-4198-85c0-84257b9abd37 //
        public bool Astronomer_Int_d315e8a9d9e142e9901c0722899985b1_1f7c990098a0419885c084257b9abd37()
        {
            return (true);
        }
        // From Node: 245fb1ef-be32-47a5-b6e4-93b0bc50d57c //
        // Choice: Do you have any other information about the case?

 - 3e09c6d3-0418-45be-8ea8-6ce8f4a1542d //
        public bool Astronomer_Int_245fb1efbe3247a5b6e493b0bc50d57c_3e09c6d3041845be8ea86ce8f4a1542d()
        {
            return (true);
        }
        // From Node: 9a783efb-ad39-4481-8b85-05a620a1b3ed //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 7e081b1f-af5f-4ccb-886d-7cd89be637b6 //
        public bool Astronomer_Int_9a783efbad3944818b8505a620a1b3ed_7e081b1faf5f4ccb886d7cd89be637b6()
        {
            return (true);
        }
        // From Node: ceea2aee-0855-4bcb-a05a-b5466a8286ef //
        // Choice: Where were you at the time of the murder? - 318fe419-eede-48b8-b015-fac356bca549 //
        public bool Astronomer_Int_ceea2aee08554bcba05ab5466a8286ef_318fe419eede48b8b015fac356bca549()
        {
            return (true);
        }
        // From Node: ceea2aee-0855-4bcb-a05a-b5466a8286ef //
        // Choice: Do you know why someone would have wanted to hurt the victim? - c793fca2-bc50-4935-b04a-0133a00836b2 //
        public bool Astronomer_Int_ceea2aee08554bcba05ab5466a8286ef_c793fca2bc504935b04a0133a00836b2()
        {
            return (true);
        }
        // From Node: 06dd7460-0954-46c8-9485-fb594e0878dc //
        // Choice: Do you have any other information about the case?

 - 3a3e9a8a-27d6-4330-9f6c-64d32e4e619d //
        public bool Astronomer_Int_06dd7460095446c89485fb594e0878dc_3a3e9a8a27d643309f6c64d32e4e619d()
        {
            return (true);
        }
        // From Node: b1c793f8-e2cb-46ed-bf2f-4ad9c50c0b94 //
        // Choice: Where were you at the time of the murder? - a6519480-def8-4530-8d4f-aeed05219492 //
        public bool Astronomer_Int_b1c793f8e2cb46edbf2f4ad9c50c0b94_a6519480def845308d4faeed05219492()
        {
            return (true);
        }
        // From Node: 0611dee7-8668-445c-b32d-d273d9354c40 //
        // Choice: Where were you at the time of the murder? - db52a282-7eb9-4440-bd37-f2db5df6c8ae //
        public bool Astronomer_Int_0611dee78668445cb32dd273d9354c40_db52a2827eb94440bd37f2db5df6c8ae()
        {
            return (true);
        }
        // From Node: 922c28f3-6d50-40b9-95bb-50f6b98a7fa9 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 2c9ffe4d-4b4f-4623-9a70-a0534d03dcc0 //
        public bool Astronomer_Int_922c28f36d5040b995bb50f6b98a7fa9_2c9ffe4d4b4f46239a70a0534d03dcc0()
        {
            return (true);
        }
        // From Node: 173dfcd7-b7d0-4e2d-8971-a05afb3d9cdd //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 7a719a84-ec67-41e8-8f4c-1d44e9b48410 //
        public bool Astronomer_Int_173dfcd7b7d04e2d8971a05afb3d9cdd_7a719a84ec6741e88f4c1d44e9b48410()
        {
            return (true);
        }
        // From Node: 173dfcd7-b7d0-4e2d-8971-a05afb3d9cdd //
        // Choice: Do you have any other information about the case?

 - daf755e1-92df-4ac2-97fc-bbb7991681be //
        public bool Astronomer_Int_173dfcd7b7d04e2d8971a05afb3d9cdd_daf755e192df4ac297fcbbb7991681be()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //

    }
}