using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputDirection
    {
        NuLL,
        Left,
        Right,
        Up,
        Down
    }
public class playerController : MonoBehaviour
{
    public float speed = 1;
    InputDirection inputDirection;
    Vector3 mousePos;
    bool activeInput;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateAction());
        IEnumerator UpdateAction()
        {
            while(true)
            {
                yield return 0;
                GetInputDirection();
            }

        }
    }

    void GetInputDirection()
    {
        inputDirection = InputDirection.NuLL;
        if (Input.GetMouseButtonDown(0))
        {
            activeInput = true;
            mousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0) && activeInput)
        {
            Vector3 vec = Input.mousePosition - mousePos;
            if (vec.magnitude > 20)
            {
                var angle = Mathf.Acos(Vector3.Dot(vec.normalized, Vector2.up));
                Debug.Log(angle);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

    }
}

    