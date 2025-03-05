using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [Tooltip("점수")]
    [SerializeField] int Hits = 2;
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Hit")) return;
            Hits--;
            Debug.Log($"이 물체에 여러번 부딪쳤다 : {Hits}");
            // Score UI에 추가하기
        if (Hits <= 0)
        {
            Destroy(gameObject);
        }
    }
}
