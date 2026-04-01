using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ui_ItemButton : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI nameTitle;
    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private TextMeshProUGUI description;
    private SO_GenericItem itemData;
    private Ui_Merchant uiMerchant;
    public void SetUp(Ui_Merchant soMerchant, SO_GenericItem item)
    {
        uiMerchant = soMerchant;
        itemData= item;
        image.sprite= item.Icon;
        nameTitle.SetText($"{item.Name}");
        price.SetText($"{item.Price}");
       // description.SetText(item.Description);
    }

    public void OnCLick()
    {
        uiMerchant.OnSelected(itemData);
    }
}
