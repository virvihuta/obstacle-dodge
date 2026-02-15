using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 3f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
       if (Time.time > TimeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
