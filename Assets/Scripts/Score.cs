using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangePos()
    {
        Vector2 newPos = transform.position;
        newPos.y *= -1;
        transform.position = newPos;
    }

}
