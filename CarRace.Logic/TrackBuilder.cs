using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRace.Logic
{
    public class TrackBuilder
    {
        private (int, int)[] _sectionInfos;
        private Track? _track;

        public Track? RaceTrack => _track;

        public TrackBuilder((int, int)[] sectionInfos, bool trackShallLoop = false)
        {
            _sectionInfos = sectionInfos;


            List<Section> allSections = [];
            Section? lastSection = null;

            foreach (var section in _sectionInfos)
            {
                Section newSection = new(section.Item1, section.Item2);

                if (allSections.Count > 0)
                    lastSection!.AddAfterMe(newSection);

                lastSection = newSection;
                allSections.Add(newSection);
            }
            _track = new Track(allSections, trackShallLoop);

        }


    }
}
