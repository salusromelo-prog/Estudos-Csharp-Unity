using UnityEngine;

public class exercicio5 : MonoBehaviour
{

    public float moedas;
    float dobro;
    int dias;
    void Start()
    {
        
        dobro = moedas*2;
        while (moedas < dobro)
        {
            moedas = moedas + (moedas*0.10f);
            Debug.Log("Saldo do dia: " + moedas);
            dias++;

        }
        Debug.Log("Dias necessarios: " + dias);



    }


}
