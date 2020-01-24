using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class Character2D : MonoBehaviour
{
    protected SpriteRenderer spr;
    protected Animator anim;
    protected Rigidbody2D rb2D;
    [SerializeField, Range(1f, 10f)]
    protected float jumpForce = 7f; 
   
    [SerializeField]
    protected float moveSpeed = 2f;

    void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    protected bool FlipSprite
    {
        get => GameplaySystem.Axis.x < 0 ? true : GameplaySystem.Axis.x > 0 ? false : spr.flipX;
    }

}
