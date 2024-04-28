using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEyes : MonoBehaviour
{
    public GameObject Eye1;
    public GameObject Eye2;
    public GameObject Eye3;
    public GameObject Eye4;
    public GameObject Eye5;
    public GameObject Eye6;
    public GameObject Eye7;
    public GameObject Eye8;
    public GameObject DoorClose;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Eye1.SetActive(true);
            Eye2.SetActive(true);
            Eye3.SetActive(true);
            Eye4.SetActive(true);
            Eye5.SetActive(true);
            Eye6.SetActive(true);
            Eye7.SetActive(true);
            Eye8.SetActive(true);
            DoorClose.SetActive(true);
        }
    }
}
