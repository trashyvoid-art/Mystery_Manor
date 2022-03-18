using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public class ItemPickup : BasicInteractable
    {
        ItemObject item;
        private void Awake()
        {
            item = new ItemObject();
        }

        private void Update()
        {
            //VERY IMPORTANT FIGURE OUT INTERACTION CODE ALREADY HERE
            //if (Input.GetKey(KeyCode.E))
            //{
            //    item.PickupItem();
            //}
            //VERY IMPORTANT FIGURE OUT INTERACTION CODE ALREADY HERE
        }
        public override void Down()
        {
            item.PickupItem();
            base.Down();
        }
    }
}
