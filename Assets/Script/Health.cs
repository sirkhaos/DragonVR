using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public damageType type = damageType.enemy;

    [SerializeField]
    private float healthPoints =100.0f;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Animator>() != null)
        {
            animator = GetComponent<Animator>();
            animator.SetFloat("health", HealthPoints);
        }
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

            if (animator != null)
            {
                animator.SetFloat("health", HealthPoints);
            }

            if (healthPoints<=0)
            {
                GetComponent<Rigidbody>().useGravity = true;
                if (type == damageType.enemy)
                {
                    Destroy(gameObject, 2.0f);
                }
            }
        }
    }


}