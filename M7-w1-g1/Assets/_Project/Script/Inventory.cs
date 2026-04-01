using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<ItemInstance> items = new List<ItemInstance>();
    [SerializeField] private int money;

    public static Inventory Instance {get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    public int Money { get { return money; } set { money = Mathf.Max(0, value); } }
    private int GetItem(SO_GenericItem item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Item == item)
            {
                return i;
            }
        }
        return -1;
    }
    public void Additem(SO_GenericItem item, int amount)
    {
        if (amount < 1) return;
        int index= GetItem(item);
        if (index < 0) items.Add(new ItemInstance(item, amount));
        else items[index].Amount += amount;
    }
}
