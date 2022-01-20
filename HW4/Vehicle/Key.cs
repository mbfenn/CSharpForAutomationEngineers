using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    /// <summary>
    /// A key struct
    /// </summary>
    public struct Key
    {
        /// <summary>
        /// First part of the key
        /// </summary>
        public int sectionOne { get; set; }

        /// <summary>
        /// Second part of the key
        /// </summary>
        public int sectionTwo { get; set; }

        /// <summary>
        /// Third part of a key
        /// </summary>
        public int sectionThree { get; set; }

        /// <summary>
        /// If this key matches another key
        /// </summary>
        /// <param name="otherKey">The other key</param>
        /// <returns>True if the keys match</returns>
        public bool KeyMatches(Key otherKey)
        {
            return otherKey.sectionOne == sectionOne && otherKey.sectionTwo == sectionTwo && otherKey.sectionThree == sectionThree;
        }
    }
}
