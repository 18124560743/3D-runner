using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{public float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1111111");
    }

    // Update is called once per frame
    void Update()
    { transform.Translate(new Vector3(0, 0,speed * Time.deltaTime));



        
    }
}
