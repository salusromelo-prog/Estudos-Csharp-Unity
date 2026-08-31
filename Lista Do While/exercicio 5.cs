using UnityEngine;

public class exercicio5 : MonoBehaviour
{

    public int vidas;
    int passos;

    void Start()
    {

        do
        {
            vidas -= 1;
            passos++;
            Debug.Log("restam " + vidas + "vidas");

        } while (vidas != 0);

        Debug.Log("voce conseguiu dar " + passos + " passos");
    }


}
