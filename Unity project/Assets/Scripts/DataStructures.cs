using System.Collections;
using UnityEngine;

public class DataStructures : MonoBehaviour
{

    //public int[] scores = new int[20];

    public int[,] table = new int[5, 5];

    void Start()
    {
        //for(int i=1; i<=20; i++)
        //{
        //    scores[i-1] = i*10;
        //}
        //foreach (int i in scores)
        //{
        //    Debug.Log(i);
        //}

        for(int c=0; c<=4; c++)
        {
            for (int r = 0; r <= 4; r++)
            {
                table[c, r] = (c+1) * (r+1);
            }
        }
        foreach (int cell in table)
        {
            Debug.Log(cell);
        }
    }

    void Update()
    {
       
    }
}
