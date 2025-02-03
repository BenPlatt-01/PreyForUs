using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public GameObject flashlightOnPlayer;   // Object representing the flashlight pickup
    public GameObject flashlightText;       // UI text for flashlight instructions
    public GameObject flashlightSpotlightOn; // The actual flashlight light

    private bool isFlashlightOn = false;     // Track flashlight state

    void Update()
    {
        if (flashlightOnPlayer.activeSelf) // Check if flashlight is picked up
        {
            flashlightText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F)) // Toggle flashlight when F is pressed
            {
                isFlashlightOn = !isFlashlightOn;
                flashlightSpotlightOn.SetActive(isFlashlightOn);
            }
        }
        else
        {
            flashlightText.SetActive(false); // Hide UI if flashlight is not available
        }
    }
}
