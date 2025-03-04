using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    float movementFactor; // 변수 초기화 불필요!

    [Header("기본 설정")]
    [Tooltip("x, Y, Z 값을 기입해서 이동 시킴")]
    [SerializeField] Vector3 movementVector;
    [Tooltip("이동 시간을 설정(이동 주기 - 사인 함수 한 사이클)")]
    [SerializeField] float period = 2f;
    void Start()
    {
        startingPosition = transform.position;
    }
    void Update()
    {   
        UpdateMovement();
    }
    void UpdateMovement()
    {
        if (period <= Mathf.Epsilon) {return;} //Epsilon Unity상에서 매우 작은 양수
        float cycles = Time.time / period; // 시간에 따른 증가
       
       
        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau); // -1과 1의 값을 가짐

        movementFactor = (rawSinWave + 1f) / 2f;
        
        Vector3 offset = movementVector * movementFactor; // Sin함수로 부드럽게 이동 가능
        transform.position = offset + startingPosition;
    }
}
