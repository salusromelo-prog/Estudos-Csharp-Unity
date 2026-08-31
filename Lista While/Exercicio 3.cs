using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{

    public int combustivel;
    int voltas;

    void Start()
    {

        while (combustivel > 8)
        {
            combustivel-= 8;
            voltas+= 1;
            Debug.Log("Combustivel restante = " + combustivel);
            Debug.Log ("voltas:" +  voltas);

        }
        Debug.Log("voltas totais = " +voltas);

    }


}
