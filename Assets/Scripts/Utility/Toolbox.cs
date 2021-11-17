using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sound;
using Notes;

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
        public Journal Journal { get; private set; }

        private Toolbox()
        {
            SoundPool = new SoundRepository();
            Journal = new Journal();
        }
    }
}