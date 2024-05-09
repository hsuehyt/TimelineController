# Unity Timeline Controller

This Unity script provides basic control for playing and pausing a Timeline using keyboard input. It allows you to toggle the playback state of a specified Timeline asset when the Spacebar key is pressed.

## How to Use

1. **Attach the Script**:
   - Attach this script (`TimelineController.cs`) to any GameObject in your scene (preferably the same GameObject that holds your Timeline asset).

2. **Assign the Timeline Director**:
   - In the Inspector, assign the `timelineDirector` field to the `PlayableDirector` component associated with your Timeline asset.

3. **Play and Pause**:
   - Press the Spacebar during runtime to toggle the playback state of the Timeline.
   - If the Timeline is playing, it will pause; if it's paused, it will resume playing.

## Script Explanation

- The `Update` method checks for Spacebar input and calls the `ToggleTimelinePlayback` method accordingly.
- The `ToggleTimelinePlayback` method:
  - Pauses the Timeline if it's currently playing.
  - Resumes playing the Timeline if it's paused.
  - Toggles the `isPlaying` flag to keep track of the current state.

## Notes

- Make sure you have a valid Timeline asset assigned to the `timelineDirector`.
- Adjust the script as needed for your specific project requirements.
