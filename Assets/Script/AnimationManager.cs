using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    public delegate void AnimationHandler();
    Animation animation;
    public AnimationClip Dead;
    public AnimationClip JumpDown;
    public AnimationClip JumpLoop;
    public AnimationClip JumpUp;
    public AnimationClip Roll;
    public AnimationClip Run;
    public AnimationClip TurnLeft;
    public AnimationClip TurnRight;

    public AnimationHandler animationHandler;
            
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
       
    }

    

    // Update is called once per frame
    void Update()
    {
        //animation.Play(Run.name);
        if (animationHandler!=null)
        {
            animationHandler();
        }   
    }
}
