using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Event/EventDialogue"), ]
public class Event : ScriptableObject
{
    [SerializeField] [TextArea] private string[] finalText;

    public string[] Dialogue => Dialogue;
}

