using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalVoice : MonoBehaviour
{
    public GameObject FirstTimeCheck;
    public GameObject Subtitle;
    public GameObject Activate;

    public int time = 3;

    public AudioSource audioSource;

    public bool bl_activate = false;

    private bool bl_canActivate = false;

    void Update()
    {
        if (Input.GetKeyUp("r") && bl_canActivate && !FirstTimeCheck.activeInHierarchy)
        {
            bl_canActivate = !bl_activate;
            StartCoroutine(Voice1());
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

    public IEnumerator Voice1()
    {
        FirstTimeCheck.SetActive(true);
        Subtitle.SetActive(true);
        Activate.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(time);
        Subtitle.SetActive(false);
    }
}
