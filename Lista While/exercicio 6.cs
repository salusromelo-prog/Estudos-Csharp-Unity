using UnityEngine;

public class exercicio6 : MonoBehaviour
{

    public int valor;
    int dias;

    void Start()
    {
        while (valor >= 10)
        {
            valor = valor / 2;
            dias++;
            Debug.Log("O valor restante do dia: " + valor);

        }

        Debug.Log("ficara com menos que 10 moedas em " + dias + "dias");


    }


}
