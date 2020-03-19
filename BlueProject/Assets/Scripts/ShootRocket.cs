using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRocket : MonoBehaviour
{
    public Vector2 initForce;
    public GameObject rocketPrefab;
    KeyCode rocket = KeyCode.Space;
    public int ammo;
    void Update()
    {
        if (ammo > 0 && Input.GetKeyDown(rocket))
        {
            Instantiate(rocketPrefab, transform).GetComponent<Rigidbody2D>().AddForce(initForce, ForceMode2D.Impulse);
            ammo--;
        }
    }
}
