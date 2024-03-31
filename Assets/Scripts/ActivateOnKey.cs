using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnKey : MonoBehaviour
{
    public GameObject itemToActivate;
    public bool bl_activate = false;

    private bool bl_canActivate = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("r") && bl_canActivate)
        {
            bl_canActivate = !bl_activate;
            itemToActivate.SetActive(bl_activate);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bl_canActivate = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bl_canActivate = false;
        }
    }
}
