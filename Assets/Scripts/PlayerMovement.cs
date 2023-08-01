using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    public static Vector3 MoveVelocity;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        rb.velocity = MoveVelocity;
    }

    private void Move()
    {
        MoveVelocity = new Vector3(InputController.MoveVector.x, 0, InputController.MoveVector.y) * speed;
    }
}
