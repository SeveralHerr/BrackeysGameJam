using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class HungerMeter : MonoBehaviour
{
    [SerializeField]
    private int _hunger = 10;

    public int Hunger
    {
        get { return _hunger; }
        set
        {
            if (_hunger == 0)
            {
                Debug.Log("Gameover");
            }

            else if (_hunger > maxHunger)
            {
                _hunger = maxHunger;
            }
        }
    }

    [SerializeField]
    private int hungerDecrement = 1;
    [SerializeField]
    private int maxHunger = 10;
    [SerializeField]
    private float cooldownTime = 2;
    [SerializeField]
    private bool isCoolingdown;


    public TextMeshProUGUI hungerText;

    public Button FeedME;

    private void Start()
    {
        hungerText.text = "Hunger Level: " + Hunger.ToString();
        FeedME.onClick.AddListener(Feed);
        StartCoroutine(HandleHunger());

    }

    private void Feed()
    {
        isCoolingdown = true;
        handleCooldown();
    }

    private void Update()
    {
        if (isCoolingdown)
        {
            cooldownTime -= Time.deltaTime;
        }
    }
    private IEnumerator HandleHunger()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);

            Hunger -= hungerDecrement;
            hungerText.text = "Hunger Level: " + Hunger.ToString();
        }
    }

    private void handleCooldown()
    {
        if(cooldownTime <= 0 ) 
        {
            _hunger += 1;
            cooldownTime = 2;
            isCoolingdown = false;
        }
    }

}
