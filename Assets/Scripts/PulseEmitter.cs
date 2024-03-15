using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseEmitter : MonoBehaviour
{
    public Transform PulseSpawnPoint;
    public GameObject PulsePrefab;
    public float PulseSpeed = 10;
    public float fireRate = 15f;

    private float nextTimeToFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        var pulse = Instantiate(PulsePrefab, PulseSpawnPoint.position, PulseSpawnPoint.rotation);
        pulse.GetComponent<Rigidbody>().velocity = PulseSpawnPoint.forward * PulseSpeed;
    }
}
