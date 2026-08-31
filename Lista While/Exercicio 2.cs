using UnityEngine;

public class Exercicio2 : MonoBehaviour
{


    public int xp;
    int xpjogador, cont;

    void Start()
    {

        while (xpjogador <= xp)
        {
            xpjogador += 80;
            cont++;

        }

        Debug.Log("Será necessário "+ cont + "monstros");


    }


}
