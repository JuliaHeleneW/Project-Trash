using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTrash : MonoBehaviour
{
    public GameObject instantTrash;
    public Transform dumper;
    public float cooldown;
    private float cooldownRef;

    // Start is called before the first frame update
    void Start()
    {
        cooldownRef = cooldown;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > cooldownRef)
        {
            cooldownRef = Time.time + cooldown;
            Instantiate(instantTrash, dumper);
        }
    }
}
