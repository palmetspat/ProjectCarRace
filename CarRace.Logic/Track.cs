using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic
{
    public class Track
    {
        #region field
        private readonly List<Section> _trackList;
        private readonly bool _loopedTrack;
        #endregion

        #region constructor
        public Track(List<Section>? trackList, bool trackShallLoop = false)
        {
            if (trackList == null || trackList.Count == 0)
                throw new ArgumentNullException(nameof(trackList));

            _trackList = trackList;
            _loopedTrack = trackShallLoop;

            if (LoopedTrack)
                _trackList.Last().AddAfterMe(_trackList.First());
        }
        #endregion

        #region properties
        public Section? StartSection { get => _trackList.FirstOrDefault(); }

        public int GetTotalLenght
        {
            get
            {
                int result = 0;

                foreach (var section in _trackList)
                    result += section.Length;

                return result;
            }
        }

        public int GetMaxSpeed
        {
            get
            {
                int result = 0;

                foreach (var section in _trackList)
                    if (section.MaxSpeed > result)
                        result = section.MaxSpeed;

                return result;
            }
        }

        public bool LoopedTrack => _loopedTrack;
        #endregion

    }
}
