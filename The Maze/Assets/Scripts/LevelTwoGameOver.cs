using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTwoGameOver : MonoBehaviour
{

private AudioSource endAudioTwo;
public AudioClip enemyCollisionTwo;

    void StartTwo()
    {
        endAudioTwo = GetComponent<AudioSource>();
    }

    public void EndGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerEnter(Collider otherTwo)
    {
        if(otherTwo.gameObject.tag.Equals("Bad2")) { 
            EndGame2();
            endAudioTwo.PlayOneShot(enemyCollisionTwo, 1.0f);
        }
    }
}
