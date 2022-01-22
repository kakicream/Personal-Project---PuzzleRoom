using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivatorController : MonoBehaviour
{
    public GameObject keyToActivate;

    AudioSource audioToPlay; // Check again for sounds
    public AudioClip keyCling;

    [SerializeField] private bool remoteON = true;

    private void Start()
    {
        audioToPlay = GetComponent<AudioSource>();
    }

    public void KeyActivation()
    {
        if (remoteON == true)
        {
            audioToPlay.PlayOneShot(keyCling);
            keyToActivate.SetActive(true);
            remoteON = false;
        }
        else
        {
            Destroy(gameObject);
        }

        // With some dessolving effect, and sound,
        // the remote will disappear(deactivated) / be destroyed

        //Destroy(gameObject);
    }
}
