using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource; // Assign your AudioSource in the Inspector
    public AudioClip musicClip; // Public variable for the music clip

    void Start()
    {
        // Play the music if the audio clip is assigned
        if (musicSource != null && musicClip != null)
        {
            musicSource.clip = musicClip; // Assign the audio clip to the AudioSource
            musicSource.Play(); // Start playing the music
        }
    }

    public void IncreaseVolume()
    {
        musicSource.volume = Mathf.Clamp(musicSource.volume + 0.1f, 0f, 1f); // Adjust volume increment
        Debug.Log("Volume Increased: " + musicSource.volume);
    }

    public void DecreaseVolume()
    {
        musicSource.volume = Mathf.Clamp(musicSource.volume - 0.1f, 0f, 1f); // Adjust volume decrement
        Debug.Log("Volume Decreased: " + musicSource.volume);
    }
}
