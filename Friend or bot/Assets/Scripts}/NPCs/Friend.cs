using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour, NPC, Interactuable
{

    public string Nombre;
    public Dialogue Dialogue;
    public string tipo => "Friend";

    public Dialogue GetDialogue()
    {
        return Dialogue;
    }

    public string getNombre()
    {
        return Nombre;
    }


    public void hablar(string caracteristica)
    {
        //aca habla
        
        throw new System.NotImplementedException();
    }

    public void interactuar()
    {
        throw new System.NotImplementedException();
    }
}
