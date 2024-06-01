using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface NPC
{
    string tipo { get; }

    public void hablar(string c);
    string getNombre();
    Dialogue GetDialogue();
}
