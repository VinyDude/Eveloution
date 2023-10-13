using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Runtime : MonoBehaviour
{
    public int stepCount;

    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(Run);
    }

    void Run()
    {
        for (int p = 0; p < Data.peoNum; p++)
        {
            NeralNetwork.runBrain(p);
            Data.peoData[p, 2]++;
        }

        Draw.DrawScene();

    }
}
