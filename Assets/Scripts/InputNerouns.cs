using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNerouns : MonoBehaviour
{
        public static float Age(int peo)
        {
            return Data.peoData[peo, 2];
        } 
        public static float Rnd()
        {
            return Random.Range(-1.0f, 1.0f);
        }
        public static float Blr(int peo)
        {
            if (Data.peoData[peo, 4] == 0)
            {
                if (Data.gridCo[Data.peoData[peo, 0] + 1,Data.peoData[peo, 1]] != -1 || Data.gridCo[Data.peoData[peo, 0] - 1,Data.peoData[peo, 1]] != -1 ) { return 1.0f; }
                else { return -1.0f; }
            }
            if (Data.peoData[peo, 5] == 0)
            {
                if (Data.gridCo[Data.peoData[peo, 1], Data.peoData[peo, 1]] - 1 != -1 || Data.gridCo[Data.peoData[peo, 1],Data.peoData[peo, 1]] + 1 != -1 ) { return 1.0f; }
                else { return -1.0f; }
            }
            else { return 0.0f; }
        {

        }
        } 
        public static float Osc(int peo)
        {
            if(Data.peoData[peo, 3] == 1){ Data.peoData[peo, 3] = -1; return -1; }
            if(Data.peoData[peo, 3] == -1) { Data.peoData[peo, 3] = 1; return 1; }
            else { return 0.0f; }
        }
        public static float Bfd(int peo)
        {
            if (Data.peoData[peo, 4] == 1)
            {
                if (Data.gridCo[Data.peoData[peo, 0] + 1, Data.peoData[peo, 1]] != -1) { return 1.0f; }
                else { return -1.0f; }
            }
            if (Data.peoData[peo, 4] == -1)
            {
                if (Data.gridCo[Data.peoData[peo, 0] - 1, Data.peoData[peo, 1]] != -1) { return 1.0f; }
                else { return -1.0f; }
            }
            if (Data.peoData[peo, 5] == 1)
            {
                if (Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] + 1 != -1) { return 1.0f; }
                else { return -1.0f; }
            }
            if (Data.peoData[peo, 5] == -1)
            {
                if (Data.gridCo[Data.peoData[peo, 0], Data.peoData[peo, 1]] - 1 != -1) { return 1.0f; }
                else { return -1.0f; }
            }
            else { return 0.0f; }
    }
        public static float Pop()
        {
            return Data.popUla;
        }
        public static float Lmy(int peo)
        {
            decimal numY =  (decimal)Data.peoData[peo, 7] / (decimal)Data.rowNum;
            return (float)numY;
        }
        public static float Lmx(int peo)
        {
            decimal numX = (decimal)Data.peoData[peo, 6] / (decimal)Data.rowNum;
            return (float)numX;
        }
        public static float Bdy(int peo)
        {
            decimal xD1 = (decimal)Data.rowNum - 1m - (decimal)Data.peoData[peo, 1];
            decimal xD2 = xD1 / (decimal)Data.rowNum;
        decimal xD3 = 1m - xD2;
            return (float)xD3;
    }
        public static float Bdx(int peo)
        {
            decimal xD1 = (decimal)Data.rowNum - 1m - (decimal)Data.peoData[peo, 0];
            decimal xD2 = xD1/(decimal)Data.rowNum;
            decimal xD3 = 1m - xD2;
            return (float)xD3;
        }
        public static float Bdd(int peo)
        {
            if (Bdx(peo) > Bdy(peo)) { return Bdx(peo); }
            if (Bdx(peo) < Bdy(peo)) { return Bdy(peo); }
            if (Bdx(peo) == Bdy(peo)) { return Bdx(peo); }
            else { return 0.0f; }
        }
        public static float Lyy(int peo)
        {
            return Data.peoData[peo, 1];
        }
        public static float Lxx(int peo)
        {
            return Data.peoData[peo, 0];
        } 


}
