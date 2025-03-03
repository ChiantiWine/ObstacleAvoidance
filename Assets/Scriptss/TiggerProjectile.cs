using UnityEngine;
using System.Collections.Generic;
public class TiggerProjectile : MonoBehaviour
{
    [SerializeField] List<GameObject> Projectiles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject projectile in Projectiles)
            {
                projectile.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
