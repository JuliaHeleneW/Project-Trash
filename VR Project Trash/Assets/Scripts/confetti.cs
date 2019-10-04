using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confetti : MonoBehaviour
{
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("I triggered");
        particles.GetComponent<ParticleSystem>().Play();
    }
}
