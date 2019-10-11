using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public static AudioSource sfxSource;

    // Start is called before the first frame update
    void Start()
    {
        sfxSource = GameObject.Find("OVRPlayerController").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static IEnumerator SFXSound(AudioClip SFX)
    {
        sfxSource.PlayOneShot(SFX);
        yield return new WaitForSeconds(1);
    }
}
