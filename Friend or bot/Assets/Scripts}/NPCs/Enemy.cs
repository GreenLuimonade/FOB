using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, NPC, Interactuable
{

    public string tipo => "Enemy";
    public string Nombre;
    public Dialogue Dialogue;

    public string getNombre()
    {
        return Nombre;
    }
    public Dialogue GetDialogue()
    {
        return Dialogue;
    }
    public void hablar(string c/*mentira*/)
    {
        DialogueManager.Instance.StartDialogue(Nombre, Dialogue.RootNode);
    }

    public void interactuar()
    {
        throw new System.NotImplementedException();
    }

}
