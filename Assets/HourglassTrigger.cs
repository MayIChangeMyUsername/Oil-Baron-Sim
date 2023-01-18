using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourglassTrigger : MonoBehaviour
{
    public Button m_YourFirstButton;
    Animator myanimator;

    const string Trigger_ANIM = "Trigger";
    // Start is called before the first frame update
    void Start()
    {
        myanimator = GetComponent<Animator>();
        

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myanimator.SetTrigger(Trigger_ANIM);
        }

    }

}
