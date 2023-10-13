using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputNeruon : MonoBehaviour
{
    public static bool checkMvx(int peo, int dir)
    {
        if (Data.peoData[peo, 0] + dir < 0 || Data.peoData[peo, 0] + dir > Data.rowNum - 1) { return false; }
        else if (Data.gridCo[Data.peoData[peo, 0] + dir, Data.peoData[peo, 1]] != -1) { return false; }
        else { return true; }
    }
    public static bool checkMvy(int peo, int dir)
    {
        if (Data.peoData[peo, 1] + dir < 0 || Data.peoData[peo, 1] + dir > Data.rowNum - 1) { return false; }
        else if (Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1] + dir] != -1) { return false; }
        else { return true; }
    }





    public static void Mvf(int peo, double dataX)
    {
        float tanhData = (float)Math.Tanh(dataX);
        if (Data.peoData[peo, 5] == 0 && checkMvx(peo, Data.peoData[peo, 4]))
        {
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = -1;
            Data.peoData[peo, 0] = Data.peoData[peo, 0] + Data.peoData[peo, 4];
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = peo;
            Data.peoData[peo,6] = Data.peoData[peo, 4];
        }
        if (Data.peoData[peo, 4] == 0 && checkMvy(peo, Data.peoData[peo, 5]))
        {
            Data.gridCo[Data.peoData[peo,0], Data.peoData[peo, 1]] = -1;
            Data.peoData[peo, 1] = Data.peoData[peo, 1] + Data.peoData[peo, 5];
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = peo;
            Data.peoData[peo, 7] = Data.peoData[peo, 5];
        }
    }
    public static void Mvb(int peo, double dataX) 
    {
        float tanhData = (float)Math.Tanh(dataX);
        if (Data.peoData[peo, 5] == 0 && checkMvy(peo, -Data.peoData[peo, 4]))
        {
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = -1;
            Data.peoData[peo, 0] = Data.peoData[peo, 0] - Data.peoData[peo, 4];
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = peo;
            Data.peoData[peo, 6] = Data.peoData[peo, 4];
            Data.peoData[peo, 4] = -Data.peoData[peo, 4];
        }
        if (Data.peoData[peo, 4] == 0 && checkMvy(peo, -Data.peoData[peo, 5]))
        {
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = -1;
            Data.peoData[peo, 1] = Data.peoData[peo, 1] - Data.peoData[peo, 5];
            Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] = peo;
            Data.peoData[peo, 7] = Data.peoData[peo, 5];
            Data.peoData[peo, 5] = -Data.peoData[peo, 5];
        }
    }
    public void Mvr(int peo)
    {

    }
    public void Mlr(int peo)
    {

    }
    public void Mvx(int peo)
    {

    }
    public void Mvy(int peo)
    { 

    }
}
