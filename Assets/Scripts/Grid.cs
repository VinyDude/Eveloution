using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    public static int colNum = 5;
    public static int rowNum = 5;
    public static int peoNum = 10;
    public static int popUla = peoNum;
    
    public static int[,] gridCo = new int[rowNum, colNum];

    public static int[,] peoData = new int[peoNum, 10];

    public static GameObject[] peoGO = new GameObject[peoNum];

    public static int[,,,] brainCfg = new int[peoNum, 2,2,2];//peope Nurons conections conection vars
}

public class Grid : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        initGrid();
        initPeo();
        initBrain();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void initGrid()
    {

        //Data.gridCo.Fill(0);

        for (int col = 0; col < Data.colNum; col++)
        {
            for (int row = 0; row < Data.rowNum; row++)
            {
                Data.gridCo[row, col] = -1;
            }
        }
    }

    void initPeo()
    {
        for (int peo = 0; peo < Data.peoNum; peo++)
        {


            int newPeoX = Random.Range(0, Data.rowNum - 1);
            int newPeoY = Random.Range(0, Data.colNum - 1);

            while (Data.gridCo[newPeoX, newPeoY] != -1)
            {
                newPeoX = Random.Range(0, Data.rowNum - 1);
                newPeoY = Random.Range(0, Data.colNum - 1);
            }


            Data.gridCo[newPeoX, newPeoY] = peo + 1;

            Data.peoData[peo, 0] = newPeoX; //x pos

            Data.peoData[peo, 1] = newPeoY; // y pos

            Data.peoData[peo, 2] = 0; // age

            Data.peoData[peo, 3] = 0; // osc

            Data.peoData[peo, 4] = Random.Range(-1, 2); //x face
            Data.peoData[peo, 5] = Random.Range(-1, 2); //y face
            if (Data.peoData[peo, 4] != 0 && Data.peoData[peo, 5] != 0)
            {
                Data.peoData[peo, 5] = 0;
            }
            else if (Data.peoData[peo, 4] == 0 && Data.peoData[peo, 5] == 0)
            {
                Data.peoData[peo, 4] = 1;
            }


            Data.peoData[peo, 6] = 0; //last move x
            Data.peoData[peo, 7] = 0; //last move y

        }


    }

    void initBrain()
    {
        for (int peo = 0; peo < Data.peoNum; peo++)
        {

            Data.brainCfg[peo, 0, 0, 0] = Random.Range(1, 14);
            Data.brainCfg[peo, 1, 0, 0] = Random.Range(1, 3);






        }
    }
}
