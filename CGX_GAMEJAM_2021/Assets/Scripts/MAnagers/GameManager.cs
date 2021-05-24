using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;


    void Awake()
    {
        if (manager == null)
        {
            manager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        UIManager.ui.ReturnToTitle();
    }

    public void FinishGame()
    {
        UIManager.ui.ReturnToResults();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }
}
