using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPointHPNorm : MonoBehaviour
{
    public float health = 50f;
    public GameObject Body;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Destroy(Body);
    }
}
