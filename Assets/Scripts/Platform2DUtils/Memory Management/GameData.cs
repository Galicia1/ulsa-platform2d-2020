using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData 
{
    [SerializeField]
    Player player;

    public Player Player
    {
        get => player;
        set => player = value;
    }
}
