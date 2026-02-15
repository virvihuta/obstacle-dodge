using System;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed = 10;
    
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Move using ASDW");
        Debug.Log("Dont hit the objects");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, yValue, zValue);
    }
}
