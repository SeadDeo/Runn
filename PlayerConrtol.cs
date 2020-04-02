using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConrtol : MonoBehaviour
{
    public float moveSpeed;//скорость
    public float jumpforce;//сила прыжка
    public bool isGrounded;//датчик состояния находимся на земле или нет

    public LayerMask WhatIsGrounded;//что будет землёй
    Rigidbody2D rb;
    Collider2D myCollider;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

   
    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(myCollider,WhatIsGrounded);

        rb.velocity = new Vector2(moveSpeed,rb.velocity.y);//постоянное движение
        
        if(Input.GetKeyDown(KeyCode.Space)){//прыжок 
            if(isGrounded){//ограничение на бесконечные прыжки
                rb.velocity=new Vector2(rb.velocity.x,jumpforce);
            }
           
        }
    }
}
