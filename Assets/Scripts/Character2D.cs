using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class Character2D : MonoBehaviour
{
    protected SpriteRenderer spr;
    protected Animator anim;
   
    [SerializeField]
    protected float moveSpeed = 2f;

    void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    protected bool FlipSprite
    {
        get => GameplaySystem.Axis.x < 0 ? true : GameplaySystem.Axis.x > 0 ? false : spr.flipX;
    }

}
