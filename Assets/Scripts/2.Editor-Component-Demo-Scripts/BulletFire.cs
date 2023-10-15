using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FireDirection
{
    Left,
    Right
}

public class BulletFire : MonoBehaviour
{
    [SerializeField] PlayerControl playerControl;
    [SerializeField] Bullet bulletObject;
    [SerializeField] KeyCode fireKey;

    private void FireBullet(FireDirection fireDirection)
    {
        if (bulletObject == null)
        {
            return;
        }

        GameObject bullet = Instantiate(bulletObject.gameObject);

        bullet.SetActive(true);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = Quaternion.identity;

        Bullet script = bullet.GetComponent<Bullet>();

        script.Initialise(fireDirection);
    }

    private void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            FireDirection direction = FireDirection.Left;

            if (playerControl != null)
            {
                direction = playerControl.GetFireDirection();
            }

            FireBullet(direction);
        }
    }
}
