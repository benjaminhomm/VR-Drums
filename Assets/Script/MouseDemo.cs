using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDemo : MonoBehaviour
{
    public GameObject Particle;
    public AudioSource drumBeat;

    // Start is called before the first frame update
    void Start()
    {
        drumBeat = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if(Physics.Raycast (ray, out hit))
            {
                if(hit.collider.tag == "drum")
                {
                    // Plays the given Sound once
                    drumBeat.PlayOneShot(drumBeat.clip);

                    // Plays the definded Particle System
                    Particle.GetComponent<ParticleSystem>().Play(); 
                }
                else {
                               
                }
            }
        }
    }
}
