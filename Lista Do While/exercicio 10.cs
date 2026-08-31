using UnityEngine;

public class exercicio10 : MonoBehaviour
{
    int palpites, qpalpites, sorteio;

    void Start()
    {

        sorteio = Random.Range(1, 101);

        do
        {
            palpites++;
            Debug.Log("Palpite atual: " + palpites + "Muito Baixo");
            qpalpites++;
        } while (palpites != sorteio);

        Debug.Log("Numero secreto: " + sorteio + "Palpites necessarios: " + qpalpites);

        if (qpalpites <= 25)
        {
            Debug.Log("Sortudo!");
        }
        else if (qpalpites <= 75)
        {
            Debug.Log("Na media");
        }
        else
        {
            Debug.Log("Que azar");
        }
    }


}
