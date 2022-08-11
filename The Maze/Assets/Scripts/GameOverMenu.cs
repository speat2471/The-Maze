using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
     public void Restart ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }

     public void NavMainMenu ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        }
}
