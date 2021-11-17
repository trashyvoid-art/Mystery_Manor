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

        /// <summary>
        /// The number of entries in the Journal
        /// </summary>
        public int EntryCount => Entries.Count;

        public Journal() 
        {
            Entries = new List<Entry>();
        }

        /// <summary>
        /// Add a new non-editable entry to the journal
        /// </summary>
        /// <param name="note"></param>
        public void AddEntry(string note) 
        {
            Entries.Add(new Entry(getSmallestOpenId(), note, false));
        }

        /// <summary>
        /// Adds an editable entry to the journal
        /// </summary>
        /// <param name="note"></param>
        public void AddCustomEntry(string note) 
        {
            Entries.Add(new Entry(getSmallestOpenId(), note, true));
        }

        /// <summary>
        /// Returns the entry with the id <paramref name="id"/> or null if not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entry GetEntry(int id) 
        {
            return Entries.Where(x => x.Id == id).First();
        }

        /// <summary>
        /// Returns an entry at the index <paramref name="index"/> or null if out of range
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Entry GetEntryAtIndex(int index)
        {
            if(index < 0 || index >= Entries.Count)
                return null;

            return Entries[index];
        }

        /// <summary>
        /// Removes entry at index provided.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>False if failed, true if passed</returns>
        public bool RemoveEntryAtIndex(int index) 
        {
            if (index < 0 || index >= Entries.Count)
                return false;
            Entry entry = Entries[index];
            if (!entry.CanEdit)
                return false;
            Entries.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Removes entry with the id provided
        /// </summary>
        /// <param name="id"></param>
        /// <returns>False if failed, true if passed</returns>
        public bool RemoveEntry(int id) 
        {
            Entry e = GetEntry(id);
            if(e == null)
                return false;
            if (!e.CanEdit)
                return false;
            Entries.Remove(e);
            return true;
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