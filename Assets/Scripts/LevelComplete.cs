using UnityEngine;
using UnityEngine.SceneManagement; // Include this namespace to access SceneManager

public class LevelComplete : MonoBehaviour
{
  public void LoadNextLevel ()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
