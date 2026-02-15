using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        hits += 1;
        Debug.Log("You have bumped this many times: " + hits);
    }
}
