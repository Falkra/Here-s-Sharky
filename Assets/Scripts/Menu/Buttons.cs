using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    //MENU-------------------------------
    public GameObject MenuScene;
    public GameObject Menu1;
    public GameObject HelpMenu;

    public Text helpText;

    private bool helpOn = false;

    AudioSource Exit;

    //GAME-------------------------------

    public GameObject GameScene;

    public GameObject DeleteRemains;

    //MENU---------------------------------

    void Start()
    {
      Exit = GetComponent<AudioSource>();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
    }

    //Start game
    public void ChallengeAccepted()
    {
        //DeleteRemains.SetActive(false);
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);
        Destroy(MenuScene);
        
    }
    //Switch between help and the menu
    public void HelpMe()
    {
        if (!helpOn)
        {
            Menu1.SetActive(false);
            HelpMenu.SetActive(true);
            helpText.text  = "X";
            helpOn = true;
        }
        else if (helpOn)
        {
            HelpMenu.SetActive(false);
            Menu1.SetActive(true);
            helpText.text = "?";
            helpOn = false;
        }
            
    }
    //exit
    public void GTFO()
    {
        Exit.Play(0);
        StartCoroutine(Wait());
        Application.Quit();
    }

    //GAME--------------------------------------

    //Reset for a new run
    public void Retry()
    {
        Destroy(GameScene);
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);
    }


    public void BackToMenu()
    {
        Destroy(GameScene);
        SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
    }

}
