
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public  Texture2D tex;
    public  Sprite mySprite;
    public  GameObject parent; 
    private  SpriteRenderer sr;
    private  Material mat;

    private static decimal gridSqr = 9m /(decimal)Data.rowNum;


    // Start is called before the first frame update
    void Start()
    {
        for (int peoDraw = 0; peoDraw < Data.peoNum; peoDraw++)
        {

            GameObject go2 = new GameObject("Peo");

            go2.transform.parent = parent.transform;

            go2.transform.position = new Vector3((float)gridSqr * Data.peoData[peoDraw, 0] + (float)gridSqr/2, (float)gridSqr * -Data.peoData[peoDraw, 1] - (float)gridSqr/2, -1);

            go2.transform.localScale = new Vector3((float)gridSqr, (float)gridSqr, (float)gridSqr);

            sr = go2.AddComponent<SpriteRenderer>() as SpriteRenderer;

            sr.color = new Color(0f, (float)Data.peoData[peoDraw, 0] / (float)Data.rowNum, (float)Data.peoData[peoDraw, 1] / (float)Data.rowNum, 1f);

            sr.sprite = mySprite;

            Data.peoGO[peoDraw] = go2;
        }    
    }

    public static void DrawScene()
    {
        for (int peoDraw = 0; peoDraw < Data.peoNum; peoDraw++)
        {
            Data.peoGO[peoDraw].transform.position = new Vector3((float)gridSqr * Data.peoData[peoDraw, 0] + (float)gridSqr / 2, (float)gridSqr * -Data.peoData[peoDraw, 1] - (float)gridSqr / 2, -1);
            
        }
    }
}
