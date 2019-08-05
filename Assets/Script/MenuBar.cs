using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BarType
{
    health,
    mana
}

public class MenuBar : MonoBehaviour
{
    Slider slider;

    public GameObject target;
    public BarType barType;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        //target = GameObject.Find("Player");
        switch (barType)
        {
            case BarType.health:
                slider.maxValue = target.GetComponent<Health>().HealthPoints;
                break;
            case BarType.mana:
                slider.maxValue = Weapon.MAGIC_COOLDOWN_TIME;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (barType)
        {
            case BarType.health:
                slider.value = target.GetComponent<Health>().HealthPoints;
                break;
            case BarType.mana:
                slider.value = target.GetComponent<Weapon>().magicCooldown;
                break;
        }
    }
}
