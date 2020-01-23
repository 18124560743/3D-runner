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
    }

    IEnumerator UpdateAction()
    {
        while (true)
        {
            GetInputDirection();
            playAnimation();
            yield return 0;
            
        }

    }
    void playAnimation()
    {
        if (inputDirection==InputDirection.Left)
        {

        }
        else if (inputDirection == InputDirection.Right)
        {

        }
        else if (inputDirection == InputDirection.Up)
        {

        }
        else if (inputDirection == InputDirection.Down)
        {

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
                var angleY = Mathf.Acos(Vector3.Dot(vec.normalized, Vector2.up)) * Mathf.Rad2Deg;
                var anglex = Mathf.Acos(Vector3.Dot(vec.normalized, Vector2.right)) * Mathf.Rad2Deg;
                if(angleY <=45)
                {
                    inputDirection = InputDirection.Up;
                }
                else if(angleY >=135)
                {
                    inputDirection = InputDirection.Down;
                }
                else if(anglex <= 45)
                {
                    inputDirection = InputDirection.Right;
                }
                else if(anglex>=135)
                {
                    inputDirection = InputDirection.Left;
                }
                activeInput = false;
                Debug.Log(inputDirection);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

    }
}

    