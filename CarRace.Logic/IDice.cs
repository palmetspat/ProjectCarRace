using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic
{
    // Interface für einen Würfel (Dice) mit den grundlegenden Methoden und Eigenschaften.
    public interface IDice
    {
        #region properties
        public int Dots { get; }
        #endregion properties
        #region methods
        public void Roll();
        #endregion methods
    }
}
