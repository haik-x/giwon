using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slender : MonoBehaviour
{
    public List<Transform> spawnPos = new List<Transform>();
    private string[] phrases = {"Hi there", "Run"};

    void Start()
    {

        transform.position = spawnPos[Random.Range(0,spawnPos.Count)].position;
        transform.rotation =  spawnPos[Random.Range(0,spawnPos.Count)].rotation;
        Debug.Log(phrases[Random.Range(0, phrases.Length)]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
