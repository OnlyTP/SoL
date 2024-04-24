using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName = "Apple"; // Placeholder
    public Sprite icon; 
    public GameObject itemPrefab; // The prefab to instantiate when this item is dropped
}
