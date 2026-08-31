using UnityEngine;

public class exercicio3 : MonoBehaviour
{
    public int moedas;

    void Start()
    {
        if (moedas < 400)
        {
            do
            {
                moedas+= 60;
                Debug.Log(moedas+ " moedas ao final desta missao");

            } while (moedas < 400);
        }
        else
        {
            Debug.Log("Voce ja tem 400 moedas");
        }
           
    } 



}
