using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float life = 3;
    public float damage = 10f;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
        Target target = collision.transform.GetComponent<Target>();

        if (target != null)
        {
            target.TakeDamage(damage);
        }
    }
}
