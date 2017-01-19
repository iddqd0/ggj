using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIButtonStart : MonoBehaviour {
    GameObject charChooser;

    public void onClick()
    {
        Debug.Log("You have clicked start!");
        GameObject mainMenu = GameObject.Find("MainMenu");
        //charChooser = GameObject.Find("CharChooser");

        mainMenu.SetActive(false);
        charChooser.SetActive(true);
    }

    public void onClickExit()
    {
        Application.Quit();
        Debug.Log("You have clicked exit!");
    }

    public void onClickChar1()
    {
        // add code to set player sprite to char1
        // start game
        StartGame();
    }

    public void onClickChar2()
    {
        // add code to set player sprite to char2
        // start game
        StartGame();
    }

    public void StartGame()
    {
        //enter to code to start game!
    }

    public void Start()
    {
        charChooser = GameObject.Find("CharChooser");
        charChooser.SetActive(false);
    }
}
