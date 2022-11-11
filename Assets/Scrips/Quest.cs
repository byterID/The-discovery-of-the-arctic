using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    int i = 0;
    public GameObject WinCanvas;
    public GameObject TastCanvas;
    [SerializeField] ParticleSystem WinParticles;
    bool inZone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (i == 2)
            inZone = true;
    }
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Quest")
        {
            i+=1;
        }
        if (i >= 2)
        {
            if (inZone)
            {
                WinCanvas.SetActive(true);
                TastCanvas.SetActive(false);
                WinParticles.Play();
            }
        }
    }
}
