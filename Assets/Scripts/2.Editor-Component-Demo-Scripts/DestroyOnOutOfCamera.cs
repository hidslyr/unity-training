using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnOutOfCamera : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
