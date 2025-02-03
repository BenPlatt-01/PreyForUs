using UnityEngine;

public class FlashlightPickUp : MonoBehaviour
{

    public GameObject flashlightOnPlayer;
    public GameObject pickupText;
    public GameObject flashlightSpotlight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flashlightOnPlayer.SetActive(false);
        pickupText.SetActive(false);
        flashlightSpotlight.SetActive(false);
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            pickupText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                flashlightOnPlayer.SetActive(true);
                pickupText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickupText.SetActive(false);
            
        }
    }


}
