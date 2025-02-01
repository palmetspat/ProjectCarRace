using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic
{
    // Implementierung eines Würfels (Dice), der zufällige Werte zwischen 1 und 6 liefert.
    public class DefaultDice : IDice
    {
        #region fields
        private readonly Random _random = new();
        #endregion fields
        #region properties
        public int Dots { get; private set; }
        #endregion properties
        #region methods
        public void Roll()
        {
            Dots = _random.Next(1, 7);
        }
        #endregion methods
    }
}
