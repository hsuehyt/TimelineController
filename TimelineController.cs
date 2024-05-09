using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector timelineDirector; // Reference to the Timeline director
    private bool isPlaying = true; // Flag to track whether the Timeline is currently playing

    private void Update()
    {
        // Check for Spacebar input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleTimelinePlayback(); // Toggle Timeline playback
        }
    }

    private void ToggleTimelinePlayback()
    {
        if (timelineDirector != null)
        {
            if (isPlaying)
            {
                timelineDirector.Pause(); // Pause the Timeline
            }
            else
            {
                timelineDirector.Play(); // Resume playing the Timeline
            }
            isPlaying = !isPlaying; // Toggle the flag
        }
    }
}
