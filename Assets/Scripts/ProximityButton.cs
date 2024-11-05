using UnityEngine;

public class ProximityButton : MonoBehaviour
{
    public MeshRenderer[] buttonRenderers; // Array to hold multiple Mesh Renderers
    private Color originalColor; // Store the original color
    private Color hoverColor = Color.green; // Color when in range

    void Start()
    {
        // Store the original color from the first renderer
        if (buttonRenderers.Length > 0)
        {
            originalColor = buttonRenderers[0].material.color;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger: " + other.name);
        if (other.CompareTag("MainCamera")) // Check for MainCamera tag
        {
            foreach (var renderer in buttonRenderers)
            {
                // Create a new material instance to change the color
                renderer.material = new Material(renderer.material);
                renderer.material.color = hoverColor; // Change to hover color
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited Trigger: " + other.name);
        if (other.CompareTag("MainCamera"))
        {
            foreach (var renderer in buttonRenderers)
            {
                renderer.material.color = originalColor; // Revert to original color
            }
        }
    }
}
