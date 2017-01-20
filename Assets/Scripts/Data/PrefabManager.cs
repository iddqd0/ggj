using UnityEngine;
using System.Collections;

public class PrefabManager : MonoBehaviour
{
    public static PrefabManager Script;

    public GameObject Player;
    public GameObject Wave;

    void Awake()
    {
        Script = this;
    }

    enum PrefabTags
    {
        Player,
        Wave,
        Count
    }
}
