using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyKeys : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    private AudioSource playerAudio;
    public AudioClip keyCollect;
    public bool hasKeys = false;

    void Start() {
        score = 0;
        UpdateScore(0);
        playerAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag.Equals("Key")) {
            Destroy(col.gameObject);
            UpdateScore(1);
            hasKeys = true;
            playerAudio.PlayOneShot(keyCollect, 1.0f);
        }
    }

    void UpdateScore(int scoreUp) {
        score += scoreUp;
        scoreText.text = "SCORE: " + score;
    }
}

