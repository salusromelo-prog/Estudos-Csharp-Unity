using UnityEngine;

public class exercicio10 : MonoBehaviour
{

    public int energiaInicial;
    int custo, quantidade;


    void Start()
    {
        custo = 5;
        while (energiaInicial > 0)
        {
            energiaInicial = energiaInicial -  custo;
            if (energiaInicial < 0)
            {
                energiaInicial = 0;
            }
            Debug.Log("Custo usado: " + custo);
            Debug.Log("Energia restante: " + energiaInicial);
            custo += 2;
            quantidade++;

        }

        if (quantidade >= 10)
        {
            Debug.Log("Parabens, escala lendaria!");

        }
        else
        {
            Debug.Log("Treine mais e\r\ntente de novo.");
        }
    }


}
