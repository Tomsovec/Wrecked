using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{

    const float locomotionAnimationSmoothTime = 1f;

    PlayerMovement player;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player.walking())
        {
            animator.SetFloat("Speed", .5f, locomotionAnimationSmoothTime, Time.deltaTime);
        }
        if (player.sprinting())
        {
            animator.SetFloat("Speed", 1f, locomotionAnimationSmoothTime, Time.deltaTime);
        }
        if (player.idle())
        {
            animator.SetFloat("Speed", 0f, locomotionAnimationSmoothTime, Time.deltaTime);
        }
    }
}
