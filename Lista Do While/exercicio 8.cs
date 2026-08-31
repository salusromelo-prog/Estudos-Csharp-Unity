using UnityEngine;

public class exercicio8 : MonoBehaviour
{
    public int n;
    int tabuada = 0;

    void Start()
    {

        do
        {
           
            tabuada++;
            Debug.Log(n + " x " + tabuada + " = " + n*tabuada);
        } while (tabuada < 10);

    }


}
