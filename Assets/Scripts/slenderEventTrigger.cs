using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slenderEventTrigger : MonoBehaviour
{
    public GameObject slender;
    public Collider collision;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            slender.SetActive(true);
            collision.enabled = false;
        }
        else{
        
        }
    }
}
