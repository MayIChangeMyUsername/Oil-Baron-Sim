using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class MoneyIcon : MonoBehaviour
{

    public Slider slider;

   /* public void SetMoney(int money)
    {
        
    }*/

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = FindObjectOfType<GameManager>().money; //När man ändrar slider value så ändrar den mängden "money" du har. -Oliver
    }
}
