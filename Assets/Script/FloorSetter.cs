using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSetter : MonoBehaviour
{
    public GameObject floorOnRunning;
    public GameObject floorForwand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > floorOnRunning.transform.position.z + 32)
        {
            floorOnRunning.transform.position = new Vector3(0, 0, floorOnRunning.transform.position.z + 32);
            GameObject temp = floorOnRunning;
            floorOnRunning = floorForwand;
            floorForwand = temp;
        }
    }

}
