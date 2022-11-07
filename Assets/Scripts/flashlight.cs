using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject light0;
    public bool toggle;
    public AudioSource toggleSound;

    void Star(){
        if(toggle == false){
            light0.SetActive(false);
        }else{
            light0.SetActive(true);
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.F)){
            toggle = !toggle;
            if(toggle == false){
                light0.SetActive(false);
            }
            if(toggle == true){
                light0.SetActive(true);
            }
        }
    }
}
