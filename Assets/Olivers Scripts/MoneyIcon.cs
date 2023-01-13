using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class MoneyIcon : MonoBehaviour
{

    public Slider slider;

    public void SetMoney(int money)
    {
        slider.value = money;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
