using UnityEngine;

public class exercicio8 : MonoBehaviour
{

    public int blocos;
 

    void Start()
    {
        while ( blocos > 0)
        {
            blocos -= 4;
            Debug.Log("Blocos restantes ao final dessa hora: " + blocos);

        }

    }


}
