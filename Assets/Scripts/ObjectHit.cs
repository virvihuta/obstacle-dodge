using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.clear;
        Debug.Log("Collision Occoured");
    }
}
