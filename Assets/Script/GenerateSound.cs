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
        // Initialized
        drumBeat = GetComponent<AudioSource> ();
        interactable = GetComponent<Interactable>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Plays the given Sound once
        drumBeat.PlayOneShot(drumBeat.clip);

        // Plays the definded Particle System
        Particle.GetComponent<ParticleSystem>().Play();

        // Triggers the vibration in Controller as a haptic feedback (not tested)
        if (interactable.attachedToHand)
        {
            hand = interactable.attachedToHand.handType;
            interactable.attachedToHand.TriggerHapticPulse(3500);
        }    
    }
}
