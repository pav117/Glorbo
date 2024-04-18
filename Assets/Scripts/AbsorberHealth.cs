using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorberHealth : MonoBehaviour
{
    public float health = 300f;
    public GameObject Check1;
    public GameObject Check2;
    public GameObject Check3;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Update()
    {
        if (!Check1.activeInHierarchy && !Check2.activeInHierarchy && !Check3.activeInHierarchy)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
