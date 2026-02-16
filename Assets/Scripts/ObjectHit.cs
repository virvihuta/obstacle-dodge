using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    bool hasBeenHit = false;

    public bool HasBeenHit()
    {
        return hasBeenHit;
    }

    void OnCollisionEnter(Collision other)
    {
        if (hasBeenHit) return;

        if (other.gameObject.CompareTag("Player"))
        {
            hasBeenHit = true;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
