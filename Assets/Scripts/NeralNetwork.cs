using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeralNetwork : MonoBehaviour
{
    public static void runBrain(int peo)
    {
        float[] input = new float[13];


        switch (Data.brainCfg[peo, 0, 0, 0])
        {
            case 1: input[0] = InputNerouns.Age(peo); break;
            case 2: input[0] = InputNerouns.Rnd(); break;
            case 3: input[0] = InputNerouns.Blr(peo); break;
            case 4: input[0] = InputNerouns.Osc(peo); break;
            case 5: input[0] = InputNerouns.Bfd(peo); break;
            case 6: input[0] = InputNerouns.Pop(); break;
            case 7: input[0] = InputNerouns.Lmy(peo); break;
            case 8: input[0] = InputNerouns.Lmx(peo); break;
            case 9: input[0] = InputNerouns.Bdy(peo); break;
            case 10: input[0] = InputNerouns.Bdx(peo); break;
            case 11: input[0] = InputNerouns.Bdd(peo); break;
            case 12: input[0] = InputNerouns.Lyy(peo); break;
            case 13: input[0] = InputNerouns.Lxx(peo); break;
        }
        switch (Data.brainCfg[peo, 1, 0, 0])
        {
            case 1: OutputNeruon.Mvf(peo, input[Data.brainCfg[peo, 1, 1, 0]] * Data.brainCfg[peo, 1, 1, 1]); break;
            case 2: OutputNeruon.Mvb(peo, input[Data.brainCfg[peo, 1, 1, 0]] * Data.brainCfg[peo, 1, 1, 1]); break;
        }
    }
    
        
    





}
