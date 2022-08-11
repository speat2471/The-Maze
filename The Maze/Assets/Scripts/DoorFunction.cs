using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFunction : MonoBehaviour {

private AudioSource doorAudio;
public AudioClip doorOpen;

void Start() {
    doorAudio = GetComponent<AudioSource>();
}

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag.Equals("Door")) {
            Destroy(col.gameObject);
            doorAudio.PlayOneShot(doorOpen, 1.0f);
        }
    }
}


