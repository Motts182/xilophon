using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamecontrollerScript : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        GameObject[] gO = GameObject.FindGameObjectsWithTag("GameController");
        if (gO.Length > 1) {
            GameObject.Destroy(gO[0]);
        }
    }

    public void ChangeLevel() {
        SceneManager.LoadScene(1);
    }

    public void MoreGames() {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Bio-Raptor");
    }

    public void Like()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.xilo.bio#details-reviews");
    }
}
