using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public static HealthBar instance;
    public Image healthbar;
    float maxHealth = 100f;
    public static float health;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
        health = maxHealth;
        UpdateHealth();
    }

    // Update is called once per frame

    public void AfterDamagehealth()
    {
        health -= 10f;
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        healthbar.fillAmount = health / maxHealth;
    }
}
