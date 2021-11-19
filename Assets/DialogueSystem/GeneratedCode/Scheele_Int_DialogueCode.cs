using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Scheele_Int_DialogueCode : IDialogueCode
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
        public Scheele_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: d15738d8-30da-41f7-ba23-8b062f0b713f //
string name = "Ms. Scheele";


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Scheele_Int_342889571da141e8a66b7d4eaaa893e3_e7599b3007e94e0f8bd72e183ef9a056",Scheele_Int_342889571da141e8a66b7d4eaaa893e3_e7599b3007e94e0f8bd72e183ef9a056);
            dialogueChecks.Add("Scheele_Int_342889571da141e8a66b7d4eaaa893e3_015ad8f13cb4402ebab181af68b6850f",Scheele_Int_342889571da141e8a66b7d4eaaa893e3_015ad8f13cb4402ebab181af68b6850f);
            dialogueChecks.Add("Scheele_Int_342889571da141e8a66b7d4eaaa893e3_c21d2f08331f4798a62fd20ac02f95a3",Scheele_Int_342889571da141e8a66b7d4eaaa893e3_c21d2f08331f4798a62fd20ac02f95a3);
            dialogueChecks.Add("Scheele_Int_30a13bdb827a471ea352926752f5d2d0_f77e09b18ad04e3db79b8a1f670d2c3b",Scheele_Int_30a13bdb827a471ea352926752f5d2d0_f77e09b18ad04e3db79b8a1f670d2c3b);
            dialogueChecks.Add("Scheele_Int_30a13bdb827a471ea352926752f5d2d0_f5be638dbca34e0daf45685c2c94013e",Scheele_Int_30a13bdb827a471ea352926752f5d2d0_f5be638dbca34e0daf45685c2c94013e);
            dialogueChecks.Add("Scheele_Int_1571643ca1434870ba29411e69a59787_e3a0c64451c2482cbd3eeda5104e8049",Scheele_Int_1571643ca1434870ba29411e69a59787_e3a0c64451c2482cbd3eeda5104e8049);
            dialogueChecks.Add("Scheele_Int_1571643ca1434870ba29411e69a59787_d6d936e534d047d0ba0c53ff71498cc2",Scheele_Int_1571643ca1434870ba29411e69a59787_d6d936e534d047d0ba0c53ff71498cc2);
            dialogueChecks.Add("Scheele_Int_bdab5b37c2d34f34931dfd78f771028d_30be01d2178c4400926f919e2126e9aa",Scheele_Int_bdab5b37c2d34f34931dfd78f771028d_30be01d2178c4400926f919e2126e9aa);
            dialogueChecks.Add("Scheele_Int_21beaac1bb7846fdb4e54238c5c33dab_46e6d9e4ff16484db7a1610c70fc995a",Scheele_Int_21beaac1bb7846fdb4e54238c5c33dab_46e6d9e4ff16484db7a1610c70fc995a);
            dialogueChecks.Add("Scheele_Int_121072477c7042b2950ee7f334fa37e8_1f0d7cc4f8e946c5ad6db9e2581dafb2",Scheele_Int_121072477c7042b2950ee7f334fa37e8_1f0d7cc4f8e946c5ad6db9e2581dafb2);
            dialogueChecks.Add("Scheele_Int_3650dfad90364222aa6005a105a0e9d8_2033e180f49a4dec90f4a4cbf1ebd559",Scheele_Int_3650dfad90364222aa6005a105a0e9d8_2033e180f49a4dec90f4a4cbf1ebd559);
            dialogueChecks.Add("Scheele_Int_ff14ac2427a743598a3da2d2768a969e_1ff0e6d2e906420385d0f06078745f0d",Scheele_Int_ff14ac2427a743598a3da2d2768a969e_1ff0e6d2e906420385d0f06078745f0d);
            dialogueChecks.Add("Scheele_Int_b2aa34264a7742abb49076bdcc9b5999_dd4bdb5fb6644665aba67344cb5b5b53",Scheele_Int_b2aa34264a7742abb49076bdcc9b5999_dd4bdb5fb6644665aba67344cb5b5b53);
            dialogueChecks.Add("Scheele_Int_b2aa34264a7742abb49076bdcc9b5999_a51cd635c29b481b96ca9f1c7bdded9d",Scheele_Int_b2aa34264a7742abb49076bdcc9b5999_a51cd635c29b481b96ca9f1c7bdded9d);
            dialogueChecks.Add("Scheele_Int_83744695a7094cf285dafe026efc9ad0_dec9e914bb444bb489c566b0839d4e6f",Scheele_Int_83744695a7094cf285dafe026efc9ad0_dec9e914bb444bb489c566b0839d4e6f);

        }

        // Dialogue Checks //
        // From Node: 34288957-1da1-41e8-a66b-7d4eaaa893e3 //
        // Choice: Where were you at the time of the murder? - e7599b30-07e9-4e0f-8bd7-2e183ef9a056 //
        public bool Scheele_Int_342889571da141e8a66b7d4eaaa893e3_e7599b3007e94e0f8bd72e183ef9a056()
        {
            return (true);
        }
        // From Node: 34288957-1da1-41e8-a66b-7d4eaaa893e3 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 015ad8f1-3cb4-402e-bab1-81af68b6850f //
        public bool Scheele_Int_342889571da141e8a66b7d4eaaa893e3_015ad8f13cb4402ebab181af68b6850f()
        {
            return (true);
        }
        // From Node: 34288957-1da1-41e8-a66b-7d4eaaa893e3 //
        // Choice: Do you have any other information about the case?

 - c21d2f08-331f-4798-a62f-d20ac02f95a3 //
        public bool Scheele_Int_342889571da141e8a66b7d4eaaa893e3_c21d2f08331f4798a62fd20ac02f95a3()
        {
            return (true);
        }
        // From Node: 30a13bdb-827a-471e-a352-926752f5d2d0 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - f77e09b1-8ad0-4e3d-b79b-8a1f670d2c3b //
        public bool Scheele_Int_30a13bdb827a471ea352926752f5d2d0_f77e09b18ad04e3db79b8a1f670d2c3b()
        {
            return (true);
        }
        // From Node: 30a13bdb-827a-471e-a352-926752f5d2d0 //
        // Choice: Do you have any other information about the case?

 - f5be638d-bca3-4e0d-af45-685c2c94013e //
        public bool Scheele_Int_30a13bdb827a471ea352926752f5d2d0_f5be638dbca34e0daf45685c2c94013e()
        {
            return (true);
        }
        // From Node: 1571643c-a143-4870-ba29-411e69a59787 //
        // Choice: Where were you at the time of the murder? - e3a0c644-51c2-482c-bd3e-eda5104e8049 //
        public bool Scheele_Int_1571643ca1434870ba29411e69a59787_e3a0c64451c2482cbd3eeda5104e8049()
        {
            return (true);
        }
        // From Node: 1571643c-a143-4870-ba29-411e69a59787 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - d6d936e5-34d0-47d0-ba0c-53ff71498cc2 //
        public bool Scheele_Int_1571643ca1434870ba29411e69a59787_d6d936e534d047d0ba0c53ff71498cc2()
        {
            return (true);
        }
        // From Node: bdab5b37-c2d3-4f34-931d-fd78f771028d //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 30be01d2-178c-4400-926f-919e2126e9aa //
        public bool Scheele_Int_bdab5b37c2d34f34931dfd78f771028d_30be01d2178c4400926f919e2126e9aa()
        {
            return (true);
        }
        // From Node: 21beaac1-bb78-46fd-b4e5-4238c5c33dab //
        // Choice: Do you have any other information about the case?

 - 46e6d9e4-ff16-484d-b7a1-610c70fc995a //
        public bool Scheele_Int_21beaac1bb7846fdb4e54238c5c33dab_46e6d9e4ff16484db7a1610c70fc995a()
        {
            return (true);
        }
        // From Node: 12107247-7c70-42b2-950e-e7f334fa37e8 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 1f0d7cc4-f8e9-46c5-ad6d-b9e2581dafb2 //
        public bool Scheele_Int_121072477c7042b2950ee7f334fa37e8_1f0d7cc4f8e946c5ad6db9e2581dafb2()
        {
            return (true);
        }
        // From Node: 3650dfad-9036-4222-aa60-05a105a0e9d8 //
        // Choice: Do you have any other information about the case?

 - 2033e180-f49a-4dec-90f4-a4cbf1ebd559 //
        public bool Scheele_Int_3650dfad90364222aa6005a105a0e9d8_2033e180f49a4dec90f4a4cbf1ebd559()
        {
            return (true);
        }
        // From Node: ff14ac24-27a7-4359-8a3d-a2d2768a969e //
        // Choice: Where were you at the time of the murder? - 1ff0e6d2-e906-4203-85d0-f06078745f0d //
        public bool Scheele_Int_ff14ac2427a743598a3da2d2768a969e_1ff0e6d2e906420385d0f06078745f0d()
        {
            return (true);
        }
        // From Node: b2aa3426-4a77-42ab-b490-76bdcc9b5999 //
        // Choice: Where were you at the time of the murder? - dd4bdb5f-b664-4665-aba6-7344cb5b5b53 //
        public bool Scheele_Int_b2aa34264a7742abb49076bdcc9b5999_dd4bdb5fb6644665aba67344cb5b5b53()
        {
            return (true);
        }
        // From Node: b2aa3426-4a77-42ab-b490-76bdcc9b5999 //
        // Choice: Do you have any other information about the case?

 - a51cd635-c29b-481b-96ca-9f1c7bdded9d //
        public bool Scheele_Int_b2aa34264a7742abb49076bdcc9b5999_a51cd635c29b481b96ca9f1c7bdded9d()
        {
            return (true);
        }
        // From Node: 83744695-a709-4cf2-85da-fe026efc9ad0 //
        // Choice: Where were you at the time of the murder? - dec9e914-bb44-4bb4-89c5-66b0839d4e6f //
        public bool Scheele_Int_83744695a7094cf285dafe026efc9ad0_dec9e914bb444bb489c566b0839d4e6f()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //

    }
}
