using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverchargeRaG : MonoBehaviour
{
    public RunAndGun runAndGun;

    void Update()
    {
        GameObject runAndGunGameObject = GameObject.FindGameObjectWithTag("LevelManager");
        runAndGun = runAndGunGameObject.GetComponent<RunAndGun>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            runAndGun.energy = 100;
        }
    }
}
