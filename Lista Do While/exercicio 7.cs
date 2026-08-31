using UnityEngine;

public class exercicio7 : MonoBehaviour
{
    int item, raros, aberturas;

    void Start()
    {
        do
        {
            item = Random.Range(1, 11);
            if (item == 8 || item == 9)
            {
                raros++;
                Debug.Log("Item raro");
            }
            else if (item < 8)
            {
                Debug.Log("Item comum");
            }
            else
            {
                Debug.Log("item lendario");
            }

            aberturas++;

        } while (item != 10);

        Debug.Log("Foram necessarias " + aberturas + "aberturas e veio " + raros + "itens raros");
    }


}
