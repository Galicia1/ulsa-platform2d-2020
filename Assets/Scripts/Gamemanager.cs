using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    [SerializeField]
    Score score;
    public Score score {get=>score;}

    void Awake()
    {
        instance = this;
    }
}
