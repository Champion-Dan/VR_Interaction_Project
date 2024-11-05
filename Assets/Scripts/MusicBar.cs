using UnityEngine;

public class MusicBar : MonoBehaviour
{
    public AudioSource musicSource; // Assign your AudioSource in the Inspector
    public float swipeSensitivity = 0.1f; // Sensitivity for volume change
    private float currentVolume = 0.5f; // Starting volume
    private Vector3 lastHandPosition; // Store the last position of the hand

    void Start()
    {
        if (musicSource != null)
        {
            musicSource.volume = currentVolume; // Set initial volume
            musicSource.Play(); // Start playing the music
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            // Store the initial position of the hand
            lastHandPosition = other.transform.position;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            SwipeHandler(other.transform); // Continuously check for swipe gestures
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            // Reset or stop tracking if needed
        }
    }

    void SwipeHandler(Transform handTransform)
    {
        // Get the current position of the hand
        Vector3 currentHandPosition = handTransform.position;

        // Calculate the swipe delta based on the Z-axis
        float swipeDelta = currentHandPosition.z - lastHandPosition.z;

        // Check if the swipe is significant
        if (Mathf.Abs(swipeDelta) > swipeSensitivity)
        {
            UpdateVolume(swipeDelta); // Update the volume based on the swipe
            lastHandPosition = currentHandPosition; // Update the last position
        }
    }

    void UpdateVolume(float swipeDelta)
    {
        // Adjust the current volume based on the swipe direction
        if (swipeDelta > 0) // Swipe up
        {
            currentVolume += swipeSensitivity; // Increase volume
        }
        else if (swipeDelta < 0) // Swipe down
        {
            currentVolume -= swipeSensitivity; // Decrease volume
        }

        // Clamp the volume to ensure it's between 0 and 1
        currentVolume = Mathf.Clamp(currentVolume, 0f, 1f);
        musicSource.volume = currentVolume; // Set the new volume
    }
}
