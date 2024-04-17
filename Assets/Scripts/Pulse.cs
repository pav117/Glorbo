using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float life = 3;
    public float damage = 40f;

    public RunAndGun runAndGun;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void Update()
    {
        GameObject runAndGunGameObject = GameObject.FindGameObjectWithTag("LevelManager");
        runAndGun = runAndGunGameObject.GetComponent<RunAndGun>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
        Target target = other.transform.GetComponent<Target>();
        TutorialRaGBallHealth ballRaG = other.transform.GetComponent<TutorialRaGBallHealth>();

        if (target != null)
        {
            if (!runAndGun.UIElement.activeInHierarchy)
            {
                target.TakeDamage(damage);
                if (runAndGun != null)
                {
                    runAndGun.energy = runAndGun.energy + 2;
                    print(runAndGun.energy);
                }
            }
            if (runAndGun.UIElement.activeInHierarchy)
            {
                target.TakeDamage(damage * 2f);
            }
        }

        if (ballRaG != null)
        {
            if (runAndGun.UIElement.activeInHierarchy)
            {
                ballRaG.TakeDamage(damage * 2f);
            }
        }
    }
 //   void OnCollisionEnter(Collision collision)
 //   {
 //       Debug.Log(collision.transform.name);
   //     Target target = collision.transform.GetComponent<Target>();
//
  //      if (target != null)
 //       {
  //          target.TakeDamage(damage);
 //       }
 //   }
}
