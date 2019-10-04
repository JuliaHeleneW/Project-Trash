using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmScript : MonoBehaviour
{
    public bool isOn;
    public GameObject lightObject;
    // Start is called before the first frame update
    void Start()
    {
        lightObject = GameObject.Find("LightAlarm");
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            lightObject.SetActive(true);
            StartCoroutine("RotateLight");
        }
        else
        {
            lightObject.SetActive(false);
        }
    }

    IEnumerator RotateLight()
    {
        lightObject.transform.Rotate(0, 50 * Time.deltaTime, 0);
        return null;
    }
}
