using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    public GameObject inttext, light1, light2;
    public bool toggle = true, interactable;
    //public Renderer lightBulb;
    //public Material offlight, onlight;
    public AudioSource lightSwitchSound;
    public Animator switchAnim;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                //lightSwitchSound.Play();
                switchAnim.ResetTrigger("switch");
                switchAnim.SetTrigger("switch");
            }
        }
        if(toggle == true)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            //lightBulb.material = offlight;
        }
        if (toggle == false)
        {
            light1.SetActive(true);
            light2.SetActive(true);
            //lightBulb.material = onlight;
        }
    }
}
