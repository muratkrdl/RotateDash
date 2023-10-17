using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Vector2 moveDirection;

    void Update() 
    {
        Move();    
    }

    void Move()
    {
        Vector2 newPos = transform.position;
        newPos += moveDirection * moveSpeed * Time.deltaTime;
        transform.position = newPos;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Center"))
        {
            moveSpeed *= -1;
        }    
    }

}
