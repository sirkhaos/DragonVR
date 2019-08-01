using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject leftHand, rightHand;
    public GameObject leftWeapon, rightWeapon, rightWeaponAlt, magicLaunchPoint;
    public GameObject fireMagic;
    public float weaponCooldown, magicCooldown = 0.0f;
    public bool shieldActive = false;

    Vector3 lastPositionRight, lastPositionLeft;

    public const float WEAPON_COOLDOWN_TIME = 0.5F;
    public const float MAGIC_COOLDOWN_TIME = 2.0F;

    // Start is called before the first frame update
    void Start()
    {
        rightWeaponAlt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        weaponCooldown += Time.deltaTime;
        magicCooldown += Time.deltaTime;

        if (Input.GetAxis("HTC_VIU_LeftTrigger") > 0.1f && leftWeapon.activeInHierarchy) 
        {
            //TODO: gatillo izquierdo para cubrirnos con el escudo
        }
        if (Input.GetAxis("HTC_VIU_RightTrigger") > 0.1f)
        {
            //TODO: gatillo derecho disparar fuego  si tenemos vara seleccionada
        }
        if (Input.GetAxis("HTC_VIU_LeftGrip") > 0.1f)
        {
            //TODO: mostrar / ocultar el escudo
        }
        if (Input.GetAxis("HTC_VIU_RightGrip") > 0.1f)
        {
            //TODO: cambiar de arma
        }
    }
}
