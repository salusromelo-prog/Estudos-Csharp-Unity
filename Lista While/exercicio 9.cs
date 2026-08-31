using UnityEngine;

public class exercicio9 : MonoBehaviour
{
    public int distancia;
    int rodadas;
    void Start()
    {

        while (distancia > 0)
        {
            distancia -= 5;
            Debug.Log("distancia no final da rodada: " +  distancia);
            rodadas++;

        }
        Debug.Log("Foram necessarias " + rodadas + "Rodadas");

    }


}
