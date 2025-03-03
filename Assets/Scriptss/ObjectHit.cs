using UnityEngine;

public class ObjectHit : MonoBehaviour
{


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            this.gameObject.tag = "Hit";
        }
    }
}
