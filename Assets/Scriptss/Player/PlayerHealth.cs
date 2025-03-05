
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Tooltip("HP")]
    [Range(1, 3)]
    [SerializeField] int currentHP = 2;
    [SerializeField] Image[] hearts;
    [SerializeField] GameObject gameOverContainer;

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

        if (currentHP <= 0)
        {
            PlayerGameOver();
        }
    }


    void adjustHPUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].gameObject.SetActive(i < currentHP); 
        }
    }
    void PlayerGameOver()
    {
        Destroy(this.gameObject);
        gameOverContainer.SetActive(true);
    }
}
