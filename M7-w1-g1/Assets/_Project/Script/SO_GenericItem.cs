using UnityEngine;
[CreateAssetMenu(menuName="Items", fileName ="Item")]
public class SO_GenericItem : ScriptableObject
{
    [SerializeField] private Sprite icon;
    [SerializeField] private string nameTitle;
    [SerializeField] private string description;
    [SerializeField][Min(0)] private int price;

    public Sprite Icon => icon;
    public string Name => nameTitle;   
    public string Description => description;
    public int Price => price;
}
