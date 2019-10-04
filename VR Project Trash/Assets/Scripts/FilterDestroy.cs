using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterDestroy : MonoBehaviour
{
    public string tagName;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagName)
        {
            Destroy(other.gameObject);
        }
    }
}
