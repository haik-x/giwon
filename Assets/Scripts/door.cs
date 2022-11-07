using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
   public GameObject inText;
   public bool interactable, toggle;
   public Animator doorAnim;

   void OnTriggerStay(Collider other){
       
       if(other.CompareTag("MainCamera")){
           inText.SetActive(true);
           interactable = true;
       }

   }

   void OnTriggerExit(Collider other){
       
       if(other.CompareTag("MainCamera")){
           inText.SetActive(false);
           interactable = false;
       }

   }

   void Update(){
       if(interactable){
           if(Input.GetKeyDown(KeyCode.E)){
               toggle = !toggle;
               if(toggle == true){
                   doorAnim.ResetTrigger("close");
                   doorAnim.SetTrigger("open");
               }else{
                   doorAnim.ResetTrigger("open");
                   doorAnim.SetTrigger("close");
               }
               inText.SetActive(false);
               interactable = false;

           }
       }
   }
}
