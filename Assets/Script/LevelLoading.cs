using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadLevel(int levelNumber)
    {
        SceneManager.LoadScene("Level" + levelNumber);  // Assumes scene names are "Level1", "Level2", etc.
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
