using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace game
{


    public class EnemyHealth : Health

    {
        protected override void Die()
        {
            base.Die();
            Debug.Log("Enemy died");
        }

    }
}
