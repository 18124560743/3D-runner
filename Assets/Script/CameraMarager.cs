using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMarager : MonoBehaviour
{
    public GameObject target;
    public float height;
    public float distance;
    Vector3 pos;
  // Start is called before the first frame update
    void Start() 
        
    {
        pos = transform.position;      
    }

    // Update is called once per frame
    void Update()
     {
     }
     void LateUpdate()
     {
        //transform.position = new Vector3(target.transform.position.x,
        //    target.transform.position.y + height,
        //    target.transform.position.z - distance);
        //pos.x = Mathf.Lerp(pos.x, target.transform.position.x, Time.deltaTime);
        //pos.y = Mathf.Lerp(pos.y, target.transform.position.y + height, Time.deltaTime);
        //pos.z = Mathf.Lerp(pos.z, target.transform.position.z-distance, Time.deltaTime);
        //transform.position = pos;
     }
 }
