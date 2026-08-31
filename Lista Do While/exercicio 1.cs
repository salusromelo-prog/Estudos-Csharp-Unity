using UnityEngine;

public class exercicio1 : MonoBehaviour
{
    public int n;
    int contagem, soma;
    void Start()
    {
        contagem = 1;
        do
        {
            Debug.Log(contagem);
            soma = soma + contagem;
            contagem++;
        } while (contagem != n);

        Debug.Log("soma: " + soma);
    }


}




