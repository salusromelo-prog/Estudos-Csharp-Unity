using UnityEngine;

public class exercicio2 : MonoBehaviour
{

    int tentativas, sorteio;

    void Start()
    {

        do
        {
            sorteio = Random.Range(1, 4);
            tentativas++;
            Debug.Log("Resultado da tentativa: " + sorteio);

        } while (sorteio != 1);

        Debug.Log("foram necessarias " +  tentativas + "tentativas");
    }


}
