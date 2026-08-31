using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public int vidaInimigado = 0;
    int dano = 20;
    int golpes = 0;

    void Start()
    {
        do
        {
            vidaInimigado -= 20;
            golpes++;

            Debug.Log("Golpe " + golpes + ", vida inimigo: " + vidaInimigado);

        } while (vidaInimigado > 0);

        Debug.Log("Inimigo derrotado em " + golpes + "golpes ");


    }


}
