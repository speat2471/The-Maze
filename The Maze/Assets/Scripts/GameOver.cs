using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

private AudioSource endAudio;
public AudioClip enemyCollision;

    void Start()
    {
        endAudio = GetComponent<AudioSource>();
    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Bad")) { 
            EndGame();
            endAudio.PlayOneShot(enemyCollision, 1.0f);
        }
    }
}
