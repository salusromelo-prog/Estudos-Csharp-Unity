using UnityEngine;

public class exercicio7 : MonoBehaviour
{

    public int faseAtual;
    int proximaFase;

    void Start()
    {
        faseAtual++;
        while (faseAtual % 7 != 0)
        {
            faseAtual++;

        }

        proximaFase = faseAtual;
        Debug.Log ("A proxima fase é: " +  faseAtual);
    }


}
