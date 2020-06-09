using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{

    const float locomotionAnimationSmoothTime = 1f;

    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", .5f, locomotionAnimationSmoothTime, Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", 1f, locomotionAnimationSmoothTime, Time.deltaTime);
        }
        if (!Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", 0f, locomotionAnimationSmoothTime, Time.deltaTime);
        }
    }
}
