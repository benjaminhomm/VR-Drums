using UnityEngine;
using System;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class GenerateSound : MonoBehaviour
{
    public AudioSource drumBeat;
    public GameObject Particle;

    private Interactable interactable;
    private SteamVR_Input_Sources hand;

    void Start()
    {
        drumBeat = GetComponent<AudioSource> ();
        interactable = GetComponent<Interactable>();
    }

    void OnCollisionEnter(Collision collision)
    {
        drumBeat.PlayOneShot(drumBeat.clip);
        Particle.GetComponent<ParticleSystem>().Play();

        if (interactable.attachedToHand)
        {
            hand = interactable.attachedToHand.handType;
            interactable.attachedToHand.TriggerHapticPulse(3500);
        }    
    }
}
