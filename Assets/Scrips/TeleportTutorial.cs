using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTutorial : MonoBehaviour
{
    public GameObject TutorialCanvas;
    public GameObject TutorialTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            TutorialCanvas.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TutorialCanvas.SetActive(false);
            TutorialTrigger.SetActive(false);
        }
    }
}
