using UnityEngine;


public class Flyatplayer : MonoBehaviour
{
    [Header("Default Settings")]
    [SerializeField] float speed = 0.01f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }


    void Update()
    { 
        MoveToPlayer();
        DestoryWhenReached();
    }

    

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
