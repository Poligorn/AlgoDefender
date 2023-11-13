using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int health;
    public int crystals;

    public int initHealth;
    public int healthPerUpgrade;

    private void Awake()
    {
        singleton = this;
        int healthBonus = healthPerUpgrade * PlayerPrefs.GetInt("healthGrade", 0);
        health = initHealth + healthBonus;
        crystals = PlayerPrefs.GetInt("crystals", 0);
    }

    public void TakeDamage()
    {
        if(health > 0)
        {
            health -= 1;
        }
    }

    public void AddCrystals(int newCrystals)
    {
        crystals += newCrystals;
        GameController.SaveCrystals();
    }

    public void DecCrystals(int soldCrystals)
    {
        crystals -= soldCrystals;
        GameController.SaveCrystals();
    }

}
