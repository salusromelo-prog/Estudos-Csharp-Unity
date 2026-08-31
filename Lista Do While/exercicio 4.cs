using UnityEngine;

public class exercicio4 : MonoBehaviour
{

    int dado1, dado2, soma, rodadas ;

    void Start()
    {

        do
        {
            dado1 = Random.Range(1, 7);
            dado2 = Random.Range(1, 7);
            soma = dado1 + dado2;
            rodadas++;
            Debug.Log("Dado 1 = " +  dado1 + " Dado 2 = " + dado2 + " Soma = " + soma);
        } while (soma != 7);

        Debug.Log("Foram necessarias " + rodadas + " rodadas");
    }


}
