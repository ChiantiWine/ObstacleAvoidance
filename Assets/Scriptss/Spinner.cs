using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Header("Default Settings")]
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 3f;
    [SerializeField] float zAngle = 0f;
    [SerializeField] bool isSpinning = true;

    void Start()
    {
        
    }


    void Update()
    { 
        RotateSpinning();
    }
    void OnCollisionEnter(Collision other)
    {
        StopSpinning();
    }

    void RotateSpinning()
    {
         if (isSpinning)
        {
            transform.Rotate(xAngle, yAngle, zAngle);        
        }
    }

    void StopSpinning()
    {
        isSpinning = false;
    }
}
