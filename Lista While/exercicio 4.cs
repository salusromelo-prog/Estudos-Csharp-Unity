using UnityEngine;

public class exercicio4 : MonoBehaviour
{


    public int n;
    int slime, cont;
    
    void Start()
    {
        slime = 1;
        while (slime < n)
        {
            slime = slime*2;
            Debug.Log("Quantidade =" + slime);
            cont++;
        }

        Debug.Log("Rodadas :" + cont);
    }


}
