using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform transformToFollow;

    private Vector3 originalOffset;

    // Start is called before the first frame update
    void Start()
    {
        originalOffset = transform.position - transformToFollow.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = transformToFollow.position + originalOffset;
    }
}
