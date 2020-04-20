using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingRocket : Rocket
{
    // Start is called before the first frame update
    public Transform target;
    public float rotateSpeed;
    
    void FindTarget()
    {
        Collider2D[] col = Physics2D.OverlapAreaAll(new Vector2(-9f, 5f), new Vector2(9f, -5f));
        float distance = 10000f, dis;
        foreach(Collider2D c in col)
        {
            dis = (c.transform.position - transform.position).sqrMagnitude;
            if (dis < distance && c.CompareTag("Enemy"))
            {
                distance = dis;
                target = c.transform;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 direction;
        if (target)
        {
            direction = target.position - transform.position;
            direction.Normalize();
        }
        else
        {
            direction = transform.right;
            FindTarget();
        }
        float rotateAmount = Vector3.Cross(direction, transform.right).z;
        rb.angularVelocity = -rotateAmount * rotateSpeed;
        rb.velocity = transform.right * speed;
    }
}
