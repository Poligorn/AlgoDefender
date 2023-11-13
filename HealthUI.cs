using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;

    private void Update()
    {
        healthText.text = Corn.singleton.health.ToString();
    }
}
