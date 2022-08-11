using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    private void OnTriggerEnter(Collider collisionTwo)
    {
        if(collisionTwo.tag == "Player2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

     public void NavMainMenuTwo ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }
}
