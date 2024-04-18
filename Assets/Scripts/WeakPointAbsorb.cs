using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPointAbsorb : MonoBehaviour
{
    public float health = 50f;
    public GameObject Check;
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
        Check.SetActive(false);
        Destroy(gameObject);
    }
}
