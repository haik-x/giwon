using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public Camera fpsCam;
    public GameObject impact;

    

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }

    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit,range)){
            if(hit.transform.CompareTag("Enemy")){
                GameObject go = Instantiate(impact,hit.point,Quaternion.LookRotation(hit.normal));
                Debug.Log("You shot poor Slender");
            }else{
                Debug.Log("You shot the wall");
            }
        }

}
}
