using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITips : MonoBehaviour
{
    public GameObject Tips;
    public GameObject FirstTimeCheck;

    public int time = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!FirstTimeCheck.activeInHierarchy)
            {
                StartCoroutine(DisplayTip());
            }
        }
    }

    public IEnumerator DisplayTip()
    {
        FirstTimeCheck.SetActive(true);
        Tips.SetActive(true);
        yield return new WaitForSeconds(time);
        Tips.SetActive(false);
    }
}
