using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SustainabilityIcon : MonoBehaviour
{

    public Slider slider;

    /*public void SetSustainability (int Sustainability)
    {
       
    }*/

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = FindObjectOfType<GameManager>().sustain; //N�r man �ndrar slider value s� �ndrar den m�ngden "Sustainability" du har. -Oliver

    }
}