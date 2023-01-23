using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New List", menuName = "ItemList", order = 66)]
public class ItemsInStore : ScriptableObject
{
    [field: SerializeField] public List<Item> ItemsList { get; private set; }
}
