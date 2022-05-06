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
int choices = 0;
int locationsLearned = 0;
DataTracker dt = DataTracker.Instance;
GameObject scene = GameObject.Find("SceneManager");


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Sailor_Int_465df431b06a4a9d85800e0299823d28",Sailor_Int_465df431b06a4a9d85800e0299823d28);
            conditionChecks.Add("Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6",Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6);
            conditionChecks.Add("Sailor_Int_12d82d657b5c4ddd9f8f188d9838173e",Sailor_Int_12d82d657b5c4ddd9f8f188d9838173e);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_7ff9f792d85b402f9dc69b3a088f5951",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_7ff9f792d85b402f9dc69b3a088f5951);
            eventFunctions.Add("Sailor_Int_c155a34a36ad4d0da95c10895de5194e",Sailor_Int_c155a34a36ad4d0da95c10895de5194e);
            eventFunctions.Add("Sailor_Int_d65e2a8dc36e499e917a2a17afc898e7",Sailor_Int_d65e2a8dc36e499e917a2a17afc898e7);
            eventFunctions.Add("Sailor_Int_80b8a9656ebf435994de754b7e064f63",Sailor_Int_80b8a9656ebf435994de754b7e064f63);
            eventFunctions.Add("Sailor_Int_867c7f165d1e40caac84c9ffd9dc0798",Sailor_Int_867c7f165d1e40caac84c9ffd9dc0798);
            eventFunctions.Add("Sailor_Int_4524fe528ba44c0bb340d64646a58a75",Sailor_Int_4524fe528ba44c0bb340d64646a58a75);
            eventFunctions.Add("Sailor_Int_ffe6cb32ae1f454ba769e17b7010c0b5",Sailor_Int_ffe6cb32ae1f454ba769e17b7010c0b5);
            eventFunctions.Add("Sailor_Int_f4016105eff4403ea57f3ff27c9b46a3",Sailor_Int_f4016105eff4403ea57f3ff27c9b46a3);
            eventFunctions.Add("Sailor_Int_99f9c255912d4be08cf5d2582658553f",Sailor_Int_99f9c255912d4be08cf5d2582658553f);
            eventFunctions.Add("Sailor_Int_20419980a8a74d00941ec01c56a62d8e",Sailor_Int_20419980a8a74d00941ec01c56a62d8e);
            eventFunctions.Add("Sailor_Int_084c385003424ce6b5fd0a6bc5ef4e9e",Sailor_Int_084c385003424ce6b5fd0a6bc5ef4e9e);
            eventFunctions.Add("Sailor_Int_d3d1b237ce004b1f88cd40dc2580e57b",Sailor_Int_d3d1b237ce004b1f88cd40dc2580e57b);
            eventFunctions.Add("Sailor_Int_54c362f75b864475864cc155a4bf8450",Sailor_Int_54c362f75b864475864cc155a4bf8450);
            eventFunctions.Add("Sailor_Int_7163d3ee5c3d49e3899885541a7bc25b",Sailor_Int_7163d3ee5c3d49e3899885541a7bc25b);
            eventFunctions.Add("Sailor_Int_c2669306247e43269b6a7784ba3c1c48",Sailor_Int_c2669306247e43269b6a7784ba3c1c48);
            eventFunctions.Add("Sailor_Int_a7ed3505e8e64b74aa45a24a6cd4e0db",Sailor_Int_a7ed3505e8e64b74aa45a24a6cd4e0db);
            eventFunctions.Add("Sailor_Int_eb3d313ac987472581d864773c5e48ec",Sailor_Int_eb3d313ac987472581d864773c5e48ec);
            eventFunctions.Add("Sailor_Int_cd342ba54c754393830a291aaefd1844",Sailor_Int_cd342ba54c754393830a291aaefd1844);
            eventFunctions.Add("Sailor_Int_4d78f31e6a9346e7a2980e2a710a486f",Sailor_Int_4d78f31e6a9346e7a2980e2a710a486f);
            eventFunctions.Add("Sailor_Int_85aba723976f4d209f6aed527930883c",Sailor_Int_85aba723976f4d209f6aed527930883c);
            eventFunctions.Add("Sailor_Int_d025a511cd1f4921ab83f774b130ea3b",Sailor_Int_d025a511cd1f4921ab83f774b130ea3b);
            eventFunctions.Add("Sailor_Int_a7a509ef052b43b8abd68e15d34df51c",Sailor_Int_a7a509ef052b43b8abd68e15d34df51c);
            eventFunctions.Add("Sailor_Int_017c3a67445b4d61a9d018c76d197101",Sailor_Int_017c3a67445b4d61a9d018c76d197101);
            eventFunctions.Add("Sailor_Int_435131c5b55242e1b6554584859e0941",Sailor_Int_435131c5b55242e1b6554584859e0941);
            eventFunctions.Add("Sailor_Int_ab91813a180545238ba4022937e6a8f7",Sailor_Int_ab91813a180545238ba4022937e6a8f7);
            eventFunctions.Add("Sailor_Int_0a68badc55b849c0b3dae6cfb475065e",Sailor_Int_0a68badc55b849c0b3dae6cfb475065e);
            eventFunctions.Add("Sailor_Int_e5ee591e8971465393a4404a02abd28e",Sailor_Int_e5ee591e8971465393a4404a02abd28e);

        }

        // Dialogue Checks //
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Do you have any other information about the case? - 85f8aec8-8713-42de-94f2-b01aab097575 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575()
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
        // Choice: Where were you at the time of the murder? - 57059fe8-7b99-468c-8f9b-3dc22aca7f0b //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Did you kill Scarlett? - 7ff9f792-d85b-402f-9dc6-9b3a088f5951 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_7ff9f792d85b402f9dc69b3a088f5951()
        {
            return (dt.clues >= 7);
        }


        // Condition Checks //
        // Condition From Node: ad42c76a-391f-4aee-b56e-ffb2e7ed83a6 //
        public bool Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6() {
            return (choices < 3);
        }
        // Condition From Node: 12d82d65-7b5c-4ddd-9f8f-188d9838173e //
        public bool Sailor_Int_12d82d657b5c4ddd9f8f188d9838173e() {
            return (locationsLearned > 0);
        }


        // Event Functions //
        // Event From Node: 465df431-b06a-4a9d-8580-0e0299823d28 //
        public void Sailor_Int_465df431b06a4a9d85800e0299823d28() {
choices += 1;
        }
        // Event From Node: c155a34a-36ad-4d0d-a95c-10895de5194e //
        public void Sailor_Int_c155a34a36ad4d0da95c10895de5194e() {
dt.correctAccusations += 1;
        }
        // Event From Node: d65e2a8d-c36e-499e-917a-2a17afc898e7 //
        public void Sailor_Int_d65e2a8dc36e499e917a2a17afc898e7() {
dt.showBackgroundImage += 1;
        }
        // Event From Node: 80b8a965-6ebf-4359-94de-754b7e064f63 //
        public void Sailor_Int_80b8a9656ebf435994de754b7e064f63() {
journal.AddEntry("The Sailor was in the Observatory.");
locationsLearned+=1;
dt.clues+=1;
        }
        // Event From Node: 867c7f16-5d1e-40ca-ac84-c9ffd9dc0798 //
        public void Sailor_Int_867c7f165d1e40caac84c9ffd9dc0798() {
GameObject.FindObjectOfType<AudioManager>().Play("Sean 3");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 4524fe52-8ba4-4c0b-b340-d64646a58a75 //
        public void Sailor_Int_4524fe528ba44c0bb340d64646a58a75() {
GameObject.FindObjectOfType<AudioManager>().Play("Sean End");
        }
        // Event From Node: ffe6cb32-ae1f-454b-a769-e17b7010c0b5 //
        public void Sailor_Int_ffe6cb32ae1f454ba769e17b7010c0b5() {
GameObject.FindObjectOfType<AudioManager>().Play("Sean 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: f4016105-eff4-403e-a57f-3ff27c9b46a3 //
        public void Sailor_Int_f4016105eff4403ea57f3ff27c9b46a3() {
GameObject.FindObjectOfType<AudioManager>().Play("Sean 1");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 99f9c255-912d-4be0-8cf5-d2582658553f //
        public void Sailor_Int_99f9c255912d4be08cf5d2582658553f() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 20419980-a8a7-4d00-941e-c01c56a62d8e //
        public void Sailor_Int_20419980a8a74d00941ec01c56a62d8e() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }
        // Event From Node: 084c3850-0342-4ce6-b5fd-0a6bc5ef4e9e //
        public void Sailor_Int_084c385003424ce6b5fd0a6bc5ef4e9e() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean Accuse");
        }
        // Event From Node: d3d1b237-ce00-4b1f-88cd-40dc2580e57b //
        public void Sailor_Int_d3d1b237ce004b1f88cd40dc2580e57b() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 2");
        }
        // Event From Node: 54c362f7-5b86-4475-864c-c155a4bf8450 //
        public void Sailor_Int_54c362f75b864475864cc155a4bf8450() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 1");
        }
        // Event From Node: 7163d3ee-5c3d-49e3-8998-85541a7bc25b //
        public void Sailor_Int_7163d3ee5c3d49e3899885541a7bc25b() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 1");
        }
        // Event From Node: c2669306-247e-4326-9b6a-7784ba3c1c48 //
        public void Sailor_Int_c2669306247e43269b6a7784ba3c1c48() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Scarlette 1");
        }
        // Event From Node: a7ed3505-e8e6-4b74-aa45-a24a6cd4e0db //
        public void Sailor_Int_a7ed3505e8e64b74aa45a24a6cd4e0db() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: eb3d313a-c987-4725-81d8-64773c5e48ec //
        public void Sailor_Int_eb3d313ac987472581d864773c5e48ec() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 2");
        }
        // Event From Node: cd342ba5-4c75-4393-830a-291aaefd1844 //
        public void Sailor_Int_cd342ba54c754393830a291aaefd1844() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 4d78f31e-6a93-46e7-a298-0e2a710a486f //
        public void Sailor_Int_4d78f31e6a9346e7a2980e2a710a486f() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 1");
        }
        // Event From Node: 85aba723-976f-4d20-9f6a-ed527930883c //
        public void Sailor_Int_85aba723976f4d209f6aed527930883c() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Scarlette 2");
        }
        // Event From Node: d025a511-cd1f-4921-ab83-f774b130ea3b //
        public void Sailor_Int_d025a511cd1f4921ab83f774b130ea3b() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 3");
        }
        // Event From Node: a7a509ef-052b-43b8-abd6-8e15d34df51c //
        public void Sailor_Int_a7a509ef052b43b8abd68e15d34df51c() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 017c3a67-445b-4d61-a9d0-18c76d197101 //
        public void Sailor_Int_017c3a67445b4d61a9d018c76d197101() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 2");
        }
        // Event From Node: 435131c5-b552-42e1-b655-4584859e0941 //
        public void Sailor_Int_435131c5b55242e1b6554584859e0941() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: ab91813a-1805-4523-8ba4-022937e6a8f7 //
        public void Sailor_Int_ab91813a180545238ba4022937e6a8f7() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Running");
        }
        // Event From Node: 0a68badc-55b8-49c0-b3da-e6cfb475065e //
        public void Sailor_Int_0a68badc55b849c0b3dae6cfb475065e() {
dt.showBackgroundImage = 0;
dt.currentScene = 1;
        }
        // Event From Node: e5ee591e-8971-4653-93a4-404a02abd28e //
        public void Sailor_Int_e5ee591e8971465393a4404a02abd28e() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Scream");
GameObject.FindObjectOfType<AudioManager>().Play("Knife");
GameObject.FindObjectOfType<AudioManager>().Play("Thud");
        }

    }
}
