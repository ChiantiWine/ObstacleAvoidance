using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer meshRenderer;
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }
    void Update()
    {
        DropObject();
    }

    void DropObject()
    {
        if (Time.time >= timeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true; 
        }
    }
}
