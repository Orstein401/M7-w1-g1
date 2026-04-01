using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Merchant : MonoBehaviour
{
    [SerializeField] private Ui_ItemButton itemButton;
    [SerializeField] private Transform uiParent;
    [SerializeField] private Button buyButton;
    [SerializeField] private Button sellButton;

    [SerializeField] private SO_Merchant merchant;
    private SO_GenericItem selectedItem;

    private void Awake()
    {
        SetUp();
    }
    public void SetUp()
    {
        foreach (var itemToSell in merchant.dataItems)
        {
            Ui_ItemButton ib = Instantiate(itemButton, uiParent);
            ib.SetUp(this, itemToSell);
        }
        gameObject.SetActive(true);
    }
    public void OnSelected(SO_GenericItem ItemData)
    {
        selectedItem = ItemData;
        RefreshGraphics();
    }
    public void OnBuyClicked()
    {
        if (Inventory.Instance.Money >= selectedItem.Price)
        {
            Inventory.Instance.Money-=selectedItem.Price;
            Inventory.Instance.Additem(selectedItem, 1);
            RefreshGraphics();
        }
    }
    public void RefreshGraphics()
    {
        bool canBuy= Inventory.Instance.Money >= selectedItem.Price;
        buyButton.interactable = canBuy;
    }
}