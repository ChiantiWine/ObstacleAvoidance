
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Tooltip("HP")]
    [Range(1, 3)]
    [SerializeField] int currentHP = 2;
    [SerializeField] Image[] hearts;

    void Awake()
    {
        adjustHPUI();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Hit")) return;
        currentHP--;
        adjustHPUI();
        Debug.Log($"이 물체에 여러번 부딪쳤다 : {currentHP}");
        // Score UI에 추가하기
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    void adjustHPUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHP)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else
            {
                hearts[i].gameObject.SetActive(false);
            }
        }
    }
}
