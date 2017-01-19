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
    float laneSize = 1f;

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
        //Animate waves
        animateWaves = StartCoroutine(AnimateWaves());
        while (true)
        {
            yield return new WaitForSeconds(.01f);
        }
    }

    private IEnumerator AnimateWaves()
    {
        //Create waves
        for (int i = 0; i < numberOfWaves; i++)
        {
            Waves.Add("Wave" + (i+1), Instantiate(PrefabManager.Script.Wave, PrefabManager.Script.Wave.transform.position + new Vector3(0, 0, laneSize * i), PrefabManager.Script.Wave.transform.rotation, LevelMap).GetComponent<Wave>());
        }
        //Animate waves
        while (true)
        {
            foreach (Wave wave in Waves.Values)
            {
                //wave.transform.Translate()
            }
            yield return new WaitForSeconds(.01f);
        }
    }
}
