using System;
using Unity.VisualScripting;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{ 
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerMovement.MoveVelocity.magnitude >= 0.1f)
        {
            _animator.SetBool("Move",true);
        }
        else
        {
            _animator.SetBool("Move",false);
        }
    }
}        
