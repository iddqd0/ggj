using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class GameMain : MonoBehaviour
{
    public static GameMain Script;
    public Transform LevelMap;
    public static Dictionary<string, Wave> Waves = new Dictionary<string, Wave>();
    Coroutine mainLoop;
    Coroutine animateWaves;
    int numberOfWaves = 3;

    void Awake()
    {
        Script = this;
    }

    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        mainLoop = StartCoroutine(MainLoop());
    }

    private IEnumerator MainLoop()
    {
        while (true)
        {
            //Animate waves
            animateWaves = StartCoroutine(AnimateWaves());
            yield return new WaitForSeconds(.01f);
        }
    }

    private IEnumerator AnimateWaves()
    {
        //Create waves


        while (true)
        {

            yield return new WaitForSeconds(.01f);
        }
    }
}
