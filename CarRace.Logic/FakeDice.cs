using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic
{
    public class FakeDice : IDice
    {
        #region fields
        public int Dots { get; set; }
        public bool RollWasCalled { get; private set; } = false;
        #endregion fields

        #region methods
        public void Roll()
        {
            RollWasCalled = true;
        }
        #endregion methods
    }
}
