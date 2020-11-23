using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetButton : MonoBehaviour
{
    [SerializeField] Asset assetPrefab;
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<AssetButton>();
        foreach (AssetButton button in buttons) {
            button.GetComponent<SpriteRenderer>().color = new Color32(126, 126, 126, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<AssetSpawner>().SetSelectedAsset(assetPrefab);
    }
}
