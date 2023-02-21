using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickForSkip : MonoBehaviour
{
    public Button ClickFSkip; // En variabel f�r knappen s� att jag kan koppla vilken knapp som ska utf�ra detta (Anton)
    // Start is called before the first frame update
    void Start()
    {
        Button btn = ClickFSkip.GetComponent<Button>(); //  Hittar vilken knapp vi ska klicka p� (Anton)
        btn.onClick.AddListener(ClickingOnCFSButton); // N�r man klickar p� knappen s� sker n�got (Anton)
    }
    void ClickingOnCFSButton()
    {
        Debug.Log("You have clicked the button!"); // n�r man klickat p� knappen s� vissas denna text i unity (Anton)
        GameManager.click--; // �ndrar variabeln i gamemanager med ett vid varje klick av knappen (Anton)
    }
    // Update is called once per frame
    void Update()
    {
    }
}
