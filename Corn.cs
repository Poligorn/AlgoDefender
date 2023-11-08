using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int health;

    private void Awake()
    {
        singleton = this;
    }

    public void TakeDamage()
    {
        health -= 1;
    }

}
