using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMarager : MonoBehaviour
{
    public GameObject target;
    public float height;
    public float distance;

  // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
     void Lateupdat()
    {
        transform.position = new Vector3(target.transform.position.x,
            target.transform.position.y+height,
            target.transform.position.z-distance );
        
    }
 }
