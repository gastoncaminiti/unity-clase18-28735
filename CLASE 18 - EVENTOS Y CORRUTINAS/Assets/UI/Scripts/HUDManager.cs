using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] private Text textGemBlue;
    [SerializeField] private Text textGemGreen;
    [SerializeField] private Text textGemPink;

    [SerializeField] private GameObject planelGem;

    // Update is called once per frame
    void Update()
    {
        //ACTUALIZAR LA INTERFAZ\
        UpdateGemUI();
    }

    private void UpdateGemUI()
    {
       int[] GemCounts = GameManager.instance.gemQuantity;
       textGemBlue.text = "x "+ GemCounts[0];
       textGemGreen.text = "x "+ GemCounts[1];
       textGemPink.text = "x "+ GemCounts[2];

    }

    public void TooglePanel(){
        //RESPUESTA AL PRESIONAR EL BOTTON
        planelGem.SetActive(!planelGem.activeSelf);
    }
}
