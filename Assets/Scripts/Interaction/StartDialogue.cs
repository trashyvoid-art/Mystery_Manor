using DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    [RequireComponent(typeof(DialogueManager))]
    public class StartDialogue : BasicInteractable
    {
        DialogueManager dm;

        private DialogueController dc;

        // Start is called before the first frame update
        protected override void Start()
        {
            dm = GetComponent<DialogueManager>();
            dc = FindObjectOfType<DialogueController>();
            base.Start();
        }

        public override void Down()
        {
            dm.Reset();
            dc.StartConversation(dm);
            base.Down();
        }
    }
}