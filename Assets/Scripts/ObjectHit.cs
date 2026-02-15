using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision others)
    {
        if(others.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.clear;
            gameObject.tag = "Hit";
        }
    }
}
