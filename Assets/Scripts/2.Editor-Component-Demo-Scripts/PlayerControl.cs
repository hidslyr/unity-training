using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] KeyCode moveLeftKey;
    [SerializeField] KeyCode moveRightKey;
    [SerializeField] KeyCode jumpKey;

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] float jumpHeight;

    private FireDirection fireDirection;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = transform.position;

        if (Input.GetKey(moveLeftKey))
        {
            desiredPosition.x -= moveSpeed * Time.deltaTime;

            fireDirection = FireDirection.Left;
        }

        if (Input.GetKey(moveRightKey))
        {
            desiredPosition.x += moveSpeed * Time.deltaTime;

            fireDirection = FireDirection.Right;
        }

        transform.position = desiredPosition;
    }

    public FireDirection GetFireDirection()
    {
        return fireDirection;
    }
}
