using UnityEngine;

public class exercicio9 : MonoBehaviour
{
    public int n;
    int contagem;

    void Start()
    {
        contagem = 1;
        while (contagem <= n)
        {
            Debug.Log(contagem);
            contagem++;
        }

        contagem = 1;

        do
        {
            Debug.Log(contagem);
            contagem++;
        } while (contagem <= 10);

    }

    //Com entrada 0, o while nao roda nenhuma vez, ja o DoWhile roda pelo menos uma vez

}
