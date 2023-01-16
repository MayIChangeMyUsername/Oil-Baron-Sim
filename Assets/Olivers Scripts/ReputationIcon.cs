using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReputationIcon : MonoBehaviour
{

    public Slider slider;

    public void SetReputation(int Reputation)
    {
        slider.value = Reputation;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}