using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic
{
    public class Car
    {
        #region fields
        private int _gear = 0; // Der aktuelle Gang des Autos, Standard ist 0.
        private int _speed = 0; // Die aktuelle Geschwindigkeit des Autos, Standard ist 0.
        private IDice _dice; // Ein Würfel-Objekt zur Simulation zufälliger Werte beim Beschleunigen.
        #endregion fields

        #region properties
        // Öffentliche Eigenschaft für den Zugriff auf die Geschwindigkeit.
        public int Speed
        {
            get
            {
                return _speed;
            }
        }

        // Öffentliche Eigenschaft für den Gang mit Validierung.
        public int Gear
        {
            get
            {
                return _gear;
            }
            set
            {
                // Validierung: Gang muss zwischen 0 und 6 sein.
                if (value < 0 || value > 6)
                    throw new ArgumentException("Gear should be between 0 and 6");
                else
                    _gear = value;
            }
        }
        #endregion properties

        #region constructors
        // Konstruktor ohne Parameter, verwendet einen Standard-Würfel (DefaultDice).
        public Car()
            : this(new DefaultDice())
        {
        }

        // Konstruktor mit Parameter für benutzerdefinierten Würfel.
        public Car(IDice dice)
        {
            _dice = dice;
        }
        #endregion constructors

        #region methods

        // Methode zum Beschleunigen, basierend auf dem Gang und gewürfelten Augen.
        public void Accelerate()
        {
            _dice.Roll(); // Würfelt, um eine zufällige Zahl zu generieren.
            _speed = Gear * 10 * _dice.Dots; // Berechnet die Geschwindigkeit: Gang * 10 * Würfel-Augen.
        }
        #endregion methods
    }
}
