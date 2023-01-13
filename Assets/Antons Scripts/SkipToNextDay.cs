using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipToNextDay : MonoBehaviour
{
    [SerializeField]
    KeyCode mouseOnClick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        STND();
    }
    void STND()
    {
        if (Input.GetKeyDown(mouseOnClick))
        {
            GameManager.week++;
        }
    }
}
