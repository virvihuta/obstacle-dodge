using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision others)
    {
        if (others.gameObject.tag != "Hit")
        {
            hits ++;
            Debug.Log("You have bumped this many times: " + hits);
        }
    }
}
