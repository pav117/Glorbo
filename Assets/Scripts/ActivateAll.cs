using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAll : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;

    public GameObject somethingHappens;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (item1.activeInHierarchy && item2.activeInHierarchy)
        {
            somethingHappens.SetActive(false);
        }
    }
}
