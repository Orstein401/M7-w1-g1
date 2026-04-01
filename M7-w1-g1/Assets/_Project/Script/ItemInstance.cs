using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class ItemInstance
{
    [SerializeField] private SO_GenericItem item;
    [SerializeField] private int amount;
    public SO_GenericItem Item => item;
    public int Amount
    {
        get => amount;
        set => amount= Mathf.Max(0, value);
    }
    public ItemInstance(SO_GenericItem item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}
