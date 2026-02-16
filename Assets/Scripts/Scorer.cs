using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        ObjectHit objectHit = other.gameObject.GetComponent<ObjectHit>();

        if (objectHit != null && !objectHit.HasBeenHit())
        {
            hits++;
            Debug.Log("You have bumped this many times: " + hits);
        }
    }
}
