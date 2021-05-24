using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager ui;

    public GameObject titleScreen;
    public GameObject resultScreen;

    void Awake()
    {
        if (ui == null)
        {
            ui = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ReturnToTitle()
    {
        GameManager.manager.LoadScene(0);
        titleScreen.SetActive(true);
        resultScreen.SetActive(false);
    }

    public void ReturnToResults()
    {

        GameManager.manager.LoadScene(0);
        titleScreen.SetActive(false);
        resultScreen.SetActive(true);
    }

    public void ReturnToGame()
    {

        GameManager.manager.LoadScene(1);
        titleScreen.SetActive(false);
        resultScreen.SetActive(false);
    }

    public void QuitGame()
    {
        GameManager.manager.Quit();
    }
}
