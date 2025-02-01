# CarRace Simulation

## Das Repository ProjectCarRace enthält ein Programm zur Simulation eines Autorennens. Der Quellcode ist in C# geschrieben und in den folgenden Verzeichnissen organisiert:

- CarRace.Logic: Enthält die Logik der Rennsimulation.
- CarRace.UnitTests: Beinhaltet Unit-Tests zur Überprüfung der Funktionalität.
- Zusätzlich sind Dokumentationsdateien wie CarProject_Dokumentation_Updated.docx und TDD_Car_Track_Project_Tests.docx vorhanden, die weitere Informationen zum Projekt und den durchgeführten Tests bieten.

## Übersicht Test Methoden

## Tests for the Car class

### ItShouldStandStill_GivenCreated
Ensures that a newly created car starts with a speed of 0.

### ItShouldStore_GivenGearBetweenOneAndSix
Verifies that the car correctly stores a valid gear value (between 1 and 6).

### ItShouldThrowAnExpection_GivenGearOutsideRange
Ensures that setting an invalid gear (e.g., 7) throws an ArgumentException.

### ItShouldHaveASpeedOfZero_GivenNoAcceleration
Confirms that if a car is in gear but hasn't accelerated, its speed remains 0.

### ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated
Checks that when a car is in gear 3 and accelerates, its speed falls within the expected range (30–180).

### ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots
Uses a fake dice (FakeDice) to simulate rolling a 2, verifying that the speed is correctly calculated as 3 * 10 * 2 = 60.

### ItShouldCallDiceRoll_GivenAccelerateIsCalled
Ensures that the dice roll method (Roll()) is actually called when Accelerate() is executed.

---

# FakeDice Class

A mock implementation of the `IDice` interface used for testing:

### Dots
Simulates the number of dice dots for predictable testing.

### RollWasCalled
Tracks whether `Roll()` was invoked.

### Roll()
Sets `RollWasCalled = true` to verify function calls.

---

# TrackTests.cs

## Tests for the Track class

### ItShouldSaveTheStartSectionOfATrack_GivenAnyNumbersOfSections
Verifies that the first section in a list is correctly set as the track's start section.

### ItShouldReturnTotalLength_GivenMultipleSections
Checks if the total track length is correctly calculated by summing up all section lengths.

### ItShouldReturnMaxSpeed_GivenMultipleSections
Ensures that the maximum speed of the track is determined by the fastest section.

### ItShouldThrowException_GivenEmptySectionList
Confirms that an empty section list throws an ArgumentNullException.

### ItShouldThrowException_GivenNullSectionList
Similar to the previous test but ensures a null section list also throws an ArgumentNullException.

### ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack
Validates that a looped track correctly links its last section back to the first.

---

# TrackBuilderTest.cs

## Tests for the TrackBuilder class

### ItShouldBuildAConnectedTrack_GivenSectionInformation
Ensures that a track is built correctly with the given section parameters, including verifying connections between sections.

### ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack
Checks that enabling the loop parameter correctly links the last section to the first.

---

# SectionTest.cs

## Tests for the Section class

### ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated
Ensures that when a Section is created, its length and max speed are correctly assigned.

### ItShouldConnectASectionAfterTheCurrentSection_GivenAddAfterMeIsCalled
Verifies that calling `AddAfterMe` on a section correctly links it to the next section.

### ItShouldConnectASectionBeforeTheCurrentSection_GivenAddBeforeMeIsCalled
Ensures that calling `AddBeforeMe` correctly sets the previous section reference.

### ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddAfterMeIsCalled
Checks that inserting a section between two already connected sections via `AddAfterMe` works as expected.

### ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddBeforeMeIsCalled
Similar to the previous test but ensures that `AddBeforeMe` correctly inserts a section in between.

