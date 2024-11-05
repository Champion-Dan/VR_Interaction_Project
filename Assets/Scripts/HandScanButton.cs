using UnityEngine;
using System.Collections;

public class HandScanButton : MonoBehaviour
{
    public Renderer buttonRenderer;
    public Color offColor = Color.red;
    public Color onColor = Color.green;
    public Color blinkColor = Color.yellow;
    public float blinkInterval = 0.3f;  // Interval between blinks
    public float holdTime = 2.0f;  // Time required to hold to activate
    public Vector3 pressedOffset = new Vector3(0, -0.02f, 0);
    public float moveSpeed = 5.0f;

    private bool isOn = false;
    private bool isProcessing = false;
    private Vector3 initialPosition;
    private Coroutine activationCoroutine;

    private void Start()
    {
        initialPosition = transform.localPosition;
        SetButtonColor(isOn ? onColor : offColor);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand") && !isProcessing)
        {
            Debug.Log("Player hand detected, beginning activation process.");
            activationCoroutine = StartCoroutine(ActivateButton());
            StartCoroutine(MoveButton(initialPosition + pressedOffset));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            Debug.Log("Player hand exited, cancelling activation.");
            if (activationCoroutine != null)
            {
                StopCoroutine(activationCoroutine);
                activationCoroutine = null;
            }
            SetButtonColor(isOn ? onColor : offColor);
            StartCoroutine(MoveButton(initialPosition));
            isProcessing = false;
        }
    }

    private IEnumerator ActivateButton()
    {
        isProcessing = true;
        float elapsedTime = 0f;

        // Blink while counting up to holdTime
        while (elapsedTime < holdTime)
        {
            SetButtonColor(blinkColor);
            yield return new WaitForSeconds(blinkInterval);
            SetButtonColor(isOn ? onColor : offColor);
            yield return new WaitForSeconds(blinkInterval);
            elapsedTime += blinkInterval * 2;
        }

        // Toggle the button state after hold time is reached
        isOn = !isOn;
        SetButtonColor(isOn ? onColor : offColor);
        Debug.Log(isOn ? "Button turned on." : "Button turned off.");

        // Keep the button in the final color for a few seconds (optional)
        yield return new WaitForSeconds(holdTime);

        isProcessing = false;
    }

    private IEnumerator MoveButton(Vector3 targetPosition)
    {
        while (Vector3.Distance(transform.localPosition, targetPosition) > 0.001f)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * moveSpeed);
            yield return null;
        }
    }

    private void SetButtonColor(Color color)
    {
        if (buttonRenderer != null)
        {
            buttonRenderer.material.color = color;
        }
    }
}
