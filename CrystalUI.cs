using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalUI : MonoBehaviour
{
    public Text crystalText;

    private void Update()
    {
        crystalText.text = Corn.singleton.crystals.ToString();
    }
}
