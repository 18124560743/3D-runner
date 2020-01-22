using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject floorOnRunning;
    public GameObject floorForwand;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.z > floorOnRunning.transform.position.z + 32)
        {

        }
    }
}    
    

