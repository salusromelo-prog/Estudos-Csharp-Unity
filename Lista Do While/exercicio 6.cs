using UnityEngine;

public class exercicio6 : MonoBehaviour
{
    public int energia;
    int saltos;

    void Start()
    {

        if (energia >= 7)
        {
            do
            {
                energia -= 7;
                saltos++;
                Debug.Log("Energia restante: " +  energia);
            } while (energia >= 7);

            Debug.Log("Voce realizou " + saltos + "saltos e sobrou " + energia + "energias ");
        }
        else
        {
            Debug.Log("Voce nao tem energia suficiente");
        }

    }


}
