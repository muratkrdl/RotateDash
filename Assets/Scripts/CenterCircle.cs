using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCircle : MonoBehaviour
{
    public float rotateSpeed = 5f;
    [SerializeField] float rotateWayValue = 1f;

    void Update() 
    {
        RotateBall();
        GetInput();
    }

    void RotateBall()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * rotateWayValue * Time.deltaTime);
    }

    void GetInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotateWayValue *= -1;
        }
    }

}
