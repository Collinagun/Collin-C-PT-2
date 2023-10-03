using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 _moveDir;

    // Links back to the Input Manager script on startup
    void Start()
    {
        Inputs.Init(this);
        Inputs.GameMode();
    }

    // Will allow for the change of movement speed
    void Update()
    {
        transform.position +=(_moveDir * speed * Time.deltaTime);
    }
    // Allows the change of the direction that the object is moving in
    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDir = newDirection;
    }
}
