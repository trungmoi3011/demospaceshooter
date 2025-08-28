using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace game
{


    public class EnemyHealth : MonoBehaviour
    {
        public GameObject explosionPrefab;
        private void OnTriggerEnter2D(Collider2D collision) => Die();
        private void Die()
        {
            var explosion = Instantiate(explosionPrefab, transform.position,
transform.rotation);
            Destroy(explosion, 1);
            Destroy(gameObject);

        }

    }
}

