using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Game : MonoBehaviour {

    public void InMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
