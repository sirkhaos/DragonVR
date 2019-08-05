using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum damageType
{
    player, enemy
}

public class Damage : MonoBehaviour
{
    public damageType type = damageType.enemy;
    public float damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>() != null)
        {
            if (other.GetComponent<Health>().type != type)
            {
                //el daño es que hacemos es distinto dependiendo de a quien se lo hacemos
                float currentDamage = damage;
                if (other.GetComponent<Weapon>() != null)
                {
                    // comprovando que el oponente tenga armas
                    if (other.GetComponent<Weapon>().shieldActive)
                    {
                        //coprueba si el objetido tiene su escudo activo 
                    }
                }
                other.GetComponent<Health>().HealthPoints -= currentDamage;
            }
        }
    }
}
