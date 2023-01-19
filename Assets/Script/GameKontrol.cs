using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameKontrol : MonoBehaviour
{
    public GameObject[] gameObject;
    public static bool IsHide = false;
    public static bool IsHide1 = false;
    public static bool IsHide2 = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHide)
        {
            gameObject[0].SetActive(false);
            
        }
        else
        {
            gameObject[0].SetActive(true);

            
        }
        if (IsHide1)
        {
            gameObject[2].SetActive(true);

        }
        else
        {
            gameObject[2].SetActive(false);

        }
        //if (IsHide2)
        //{
        //    gameObject[3].SetActive(true);
        //    gameObject[0].SetActive(true);

        //}
        //else
        //{
        //    gameObject[3].SetActive(false);
        //    gameObject[1].SetActive(false);

        //}
    }
}
