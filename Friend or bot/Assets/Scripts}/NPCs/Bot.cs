using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour,Interactuable
{
    public string Nombre;
    public string ColorOjos;
    public string Colorpelo;
    public string Ropa;
    public string car = "";
    public Dialogue Dialogue;
    public string tipo;
    public int NBot = 1;
    public BotManager Manager;


    public Bot(string nom, string ojos, string pelo, string ropa,int a,string tipo) 
    {
        Nombre = nom;
        ColorOjos = ojos;
        Colorpelo = pelo;
        Ropa = ropa;
        NBot = a;
        this.tipo = tipo;
    }
    public Bot(BotManager manager,int a)
    {
        Manager = manager;

    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //todo logica de caracteristica

            if (tipo == "Enemy")
            {
                int x = Random.Range(1, 3);
                switch (x)
                {
                    //miente sobre el pelo
                    case 1:
                        car = "a"; //todo lista de caracteristica de npc
                        break;
                    //miente sobre los ojos
                    case 2:
                        car = "a";
                        break;
                    //miente sobre la ropa
                    case 3:
                        car = "a";
                        break;

                }
            }
            else
            {
                int x = Random.Range(1, 6);
                switch (x)
                {

                    //vio el pelo
                    case 1:
                        car = "a"; //todo lista de caracteristica de npc
                        break;
                    //vio los ojos
                    case 2:
                        car = "a";
                        break;
                    //vio la ropa
                    case 3:
                        car = "a";
                        break;
                    //no vio nada
                    default:
                        car = "a";
                        break;
                };
            }

            hablar(car);
        }
    }

    // Trigger dialogue for this actor
 
    public void hablar(string c/*caracteristica que vio*/)
    {
        string caracteristica;
        DialogueManager.Instance.StartDialogue(Nombre, Dialogue.RootNode);
        if (tipo == "Enemy") { 
        //logica de aleatoriedad de mentira
        //caracteristica == caracteristica aleatoria de otro bot;
        }
        else
         caracteristica = c;
    }

    public void interactuar()
    {
       //DialogueManager.instance.StartDialogue(nombre, dialogue.RootNode);
    }

}
