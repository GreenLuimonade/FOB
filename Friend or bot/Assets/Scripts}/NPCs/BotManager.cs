using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotManager : MonoBehaviour
{
    public List<Bot> bots = new List<Bot>();
    List<string> nombres = new List<string>{"juan","camilo","ana","juana","camila","manuel"};
    List<string> color = new List<string> { "rojo", "cafe", "negro", "verde", "azul", "dorado" };
    List<string> ropa = new List<string> { "camisa azul", "traje rojo", "etc", "juana", "camila", "manuel" };

    void Start()
    {
        for (int i=0; i < 5; i++) 
        {
            int x = Random.Range(0, 6);
            int y = Random.Range(0, 6);
            int z = Random.Range(0, 6);
            int w = Random.Range(0, 6);
            Bot Bot = new Bot(nombres[x],color[y],color[z],ropa[w],i);
            bots.Add(Bot);
        }
    }
}
