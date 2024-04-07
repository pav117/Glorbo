using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 30f;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    private float nextTimeToFire = 0f;

    public RunAndGun runAndGun;

    // Update is called once per frame
    void Update()
    {
        GameObject runAndGunGameObject = GameObject.FindGameObjectWithTag("LevelManager");
        runAndGun = runAndGunGameObject.GetComponent<RunAndGun>();

        if (Input.GetMouseButton(0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
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

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}
