using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOnTrigger : MonoBehaviour
{
    public GameObject FirstTimeCheck;
    public GameObject Subtitle;

    public AudioSource audioSource;

    public int time = 5;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!FirstTimeCheck.activeInHierarchy)
            {
                StartCoroutine(Voice1());
            }
        }
    }

    public IEnumerator Voice1()
    {
        FirstTimeCheck.SetActive(true);
        Subtitle.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(time);
        Subtitle.SetActive(false);
    }
}
