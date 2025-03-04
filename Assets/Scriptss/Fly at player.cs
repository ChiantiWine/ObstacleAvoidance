using System.Collections;
using UnityEngine;


public class Flyatplayer : MonoBehaviour
{
    [Header("기본 설정")]
    [SerializeField] float speed = 0.01f;
    [SerializeField] Transform player;
    // [SerializeField] float delay = 0f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
        // StartCoroutine(WaitDelay());
    }


    void Update()
    {
         MoveToPlayer();
        DestoryWhenReached();
    }

    // IEnumerator WaitDelay()
    // {
    //     yield return new WaitForSeconds(delay);
        
    //      gameObject.SetActive(true);

        

    // }


    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }



    void DestoryWhenReached()
    {
        if (transform.position == playerPosition)

        {

            Destroy(gameObject);
        }
    }

    // 코루틴 써서 각 각 다른 시간에 발사되게 만들기
    // Particle effect, SFX 추가  
}
