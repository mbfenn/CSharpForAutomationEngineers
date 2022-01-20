using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    /// <summary>
    /// Class for creating keys
    /// </summary>
    public static class KeyFactory
    {
        /// <summary>
        /// Make a unique key
        /// </summary>
        /// <returns>A unique key</returns>
        public static Key MakeNewKey()
        {
            // Create the key
            Key newKey = new Key();

            // Setup a random number generator
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));

            // Set the key values with random numers
            newKey.sectionOne = random.Next();
            newKey.sectionTwo = random.Next();
            newKey.sectionThree = random.Next();

            return newKey;
        }
    }
}
