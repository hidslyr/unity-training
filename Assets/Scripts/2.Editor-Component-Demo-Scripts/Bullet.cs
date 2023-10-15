using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] AutoMove autoMove;

    public void Initialise(FireDirection direction)
    {
        if (autoMove != null)
        {
            autoMove.SetDirection(direction);
        }
    }
}
