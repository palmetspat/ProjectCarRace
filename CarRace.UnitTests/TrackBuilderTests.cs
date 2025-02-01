using CarRace.Logic;

namespace CarRace.UnitTests;

[TestClass]
public class TrackBuilderTests
{
    [TestMethod]
    public void ItShouldBuildAConnectedTrack_GivenSectionInformation()
    {
        (int, int)[] sectionInfos = [(10, 10), (20, 20), (30, 30)];

        TrackBuilder builder = new(sectionInfos);

        Section
          startSection = new(sectionInfos[0].Item1, sectionInfos[0].Item2),
          secondSection = new(sectionInfos[1].Item1, sectionInfos[1].Item2),
          thirdSection = new(sectionInfos[2].Item1, sectionInfos[2].Item2);

        startSection.AddAfterMe(secondSection);
        secondSection.AddAfterMe(thirdSection);
        Track manuallyBuiltTrack = new([startSection, secondSection, thirdSection]);

    }
}
