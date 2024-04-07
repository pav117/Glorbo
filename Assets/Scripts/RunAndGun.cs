using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAndGun : MonoBehaviour
{
    public int energy = 0;
    private int maxenergy = 100;

    public GameObject UIElement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1) && energy >= maxenergy)
        {
            StartCoroutine(BonusDamage());
        }
    }

    public IEnumerator BonusDamage()
    {
        UIElement.SetActive(true);
        yield return new WaitForSeconds(5);
        UIElement.SetActive(false);
        energy = 0;
    }
}
