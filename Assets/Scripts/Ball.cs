using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            GameManager.Instance.RestartGame();
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Score"))
        {
            GameManager.Instance.IncreaseScore();
            Score.Instance.ChangePos();

            var CenterCircle = transform.parent.GetComponent<CenterCircle>();
            if(CenterCircle != null)
            {
                CenterCircle.rotateSpeed *= 1.01f;
            }
        }
    }
}
