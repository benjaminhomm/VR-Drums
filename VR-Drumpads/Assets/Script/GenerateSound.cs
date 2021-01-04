using UnityEngine;
using System;

public class GenerateSound : MonoBehaviour
{
    public AudioSource drumBeat;
    public GameObject Particle;


    // Start is called before the first frame update
    void Start()
    {
        drumBeat = GetComponent<AudioSource> ();
    }

    void OnCollisionEnter(Collision collision)
    {
        drumBeat.PlayOneShot(drumBeat.clip);
        Particle.GetComponent<ParticleSystem>().Play();
    }
}
