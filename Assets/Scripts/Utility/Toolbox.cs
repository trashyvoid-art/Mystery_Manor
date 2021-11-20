using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sound;
using Notes;
using Player;

namespace Utility
{
    public sealed class Toolbox
    {
        private static readonly Lazy<Toolbox> lazy =
            new Lazy<Toolbox>(() => new Toolbox());
        /// <summary>
        /// The singleton instance of the Toolbox
        /// </summary>
        public static Toolbox Instance { get { return lazy.Value; } }
        /// <summary>
        /// The time contoller component
        /// </summary>
        public TimeController TimeController { get; set; }

        public SoundRepository SoundPool {  get; private set; }
        /// <summary>
        /// The player's journal
        /// </summary>
        public Journal Journal { get; private set; }
        public ToolTip ToolTip { get; set; }
        public PlayerController Player { get; set; }

        private Toolbox()
        {
            SoundPool = new SoundRepository();
            Journal = new Journal();
            
        }
    }
}