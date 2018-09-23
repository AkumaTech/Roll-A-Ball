using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
