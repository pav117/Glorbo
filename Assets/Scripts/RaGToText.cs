using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaGToText : MonoBehaviour
{
    public RunAndGun runAndGun;
    public Text meter;

    public void Start()
    {
        GameObject runAndGunGameObject = GameObject.FindGameObjectWithTag("LevelManager");
        runAndGun = runAndGunGameObject.GetComponent<RunAndGun>();

    }

    public void Update()
    {
        GameObject meterGameObject = GameObject.FindGameObjectWithTag("Meter");
        meter = meterGameObject.GetComponent<Text>();

        meter.text = runAndGun.energy.ToString();
    }
}
