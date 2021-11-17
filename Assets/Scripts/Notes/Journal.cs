using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace Notes
{
    [Serializable]
    public class Journal
    {
        [SerializeField]
        private List<Entry> Entries;

        public int EntryCount => Entries.Count;

        public Journal() 
        {
            Entries = new List<Entry>();
        }


        public void AddEntry(string note) 
        {
            Entries.Add(new Entry(getSmallestOpenId(), note, false));
        }

        public void AddCustomEntry(string note) 
        {
            Entries.Add(new Entry(getSmallestOpenId(), note, true));
        }

        public Entry GetEntry(int id) 
        {
            return Entries.Where(x => x.Id == id).First();
        }

        private int getSmallestOpenId() 
        {
            int smallest = 0;
            Entries.Sort();
            foreach (Entry entry in Entries) 
            {
                if(smallest == entry.Id)
                    smallest++;
            }
            return smallest;
        }
    }
}