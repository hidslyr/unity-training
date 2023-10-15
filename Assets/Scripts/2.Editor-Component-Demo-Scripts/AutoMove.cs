using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    FireDirection direction;


    public void SetDirection(FireDirection _direction)
    {
        direction = _direction;
    }

    private void Update()
    {
        Vector3 desiredPosition = transform.position;

        float sign = direction == FireDirection.Left ? -1 : 1;

        desiredPosition.x += sign * moveSpeed * Time.deltaTime;

        transform.position = desiredPosition;
    }
}
