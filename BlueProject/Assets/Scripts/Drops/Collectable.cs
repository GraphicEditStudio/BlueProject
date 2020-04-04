using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{
    private UnityEvent on_Collect;

    private Transform player;

    public float speed = 0.5f, minDistance = 1f;
    public int id;
    //public string powerName;

    private bool triggered = false;
    private void Start()
    {
        on_Collect = PowerUpList.instance.GetPowerUpEffect(id);
    }
    private void OnEnable()
    {
        triggered = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !triggered)
        {
            triggered = true;
            player = collision.transform;
            StartCoroutine(FollowPlayer());
        }
    }
    IEnumerator FollowPlayer()
    {
        Vector3 distance;
        float distanceSqr = minDistance * minDistance;
        distance = player.position - transform.position;
        while (distance.sqrMagnitude > distanceSqr)
        {
            transform.Translate(distance.normalized * speed);
            distance = player.position - transform.position;
            yield return null;
        }
        on_Collect.Invoke();
        gameObject.SetActive(false);
    }
}
