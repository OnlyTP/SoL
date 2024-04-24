using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public int maxFood = 10;
    public int currentFood;

    public HealthBar healthBar;
    public FoodBar foodBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentFood = maxFood;
        foodBar.SetMaxFood(maxFood);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            TakeDamage(1);
        }    
        if (Input.GetKeyDown(KeyCode.B))
        {
            Hunger(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }    

    void Hunger (int hunger)
    {
        currentFood -= hunger;
        foodBar.SetFood(currentFood);
    }

}
