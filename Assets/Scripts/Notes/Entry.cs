using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Notes
{
    [Serializable]
    public class Entry : IComparable<Entry>
    {
        [SerializeField]
        private int id;
        /// <summary>
        /// The id/position of this entry.
        /// </summary>
        public int Id { get => id; private set => id = value; }

        [SerializeField]
        private string note;
        /// <summary>
        /// The actual content of this entry
        /// </summary>
        public string Note { get => note; private set => note = value; }

        [SerializeField]
        private bool canEdit;
        /// <summary>
        /// True if this entry can be edited and changed
        /// </summary>
        public bool CanEdit { get => canEdit; set => canEdit = value; }

        public Entry(int id, string note, bool canEdit = false) 
        {
            this.Id = id;
            this.Note = note;
            this.CanEdit = canEdit;
        }

        /// <summary>
        /// Updates the note if it can be edited
        /// </summary>
        /// <param name="newNote"></param>
        /// <returns>returns the new note value</returns>
        public string UpdateNote(string newNote) 
        {
            if(canEdit)
                Note = newNote;
            return Note;
        }

        public int CompareTo(Entry other)
        {
            return id.CompareTo(other.Id);
        }
    }
}