using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 3f;
    void Start()
    {
        
    }

    void Update()
    {
       if (Time.time > TimeToWait)
        {
            Debug.Log("Lookout Below!");
        }
    }
}
