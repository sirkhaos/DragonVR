using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public damageType type = damageType.enemy;

    [SerializeField]
    private float healthPoints =100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float HealthPoints
    {
        get
        {
            return healthPoints;
        }
        set
        {
            healthPoints = value;

            if (healthPoints<=0)
            {
                //TODO: gestionar muerte del personaje
            }
        }
    }


}