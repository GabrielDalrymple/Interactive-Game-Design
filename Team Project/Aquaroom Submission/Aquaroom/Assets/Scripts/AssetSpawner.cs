using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetSpawner : MonoBehaviour
{
    Asset asset;
    private void OnMouseDown() { SpawnAsset(GetPosClicked()); }

    public void SetSelectedAsset(Asset assetToSelect) { asset = assetToSelect; }

    private Vector2 GetPosClicked() {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return worldPos;
    }

    private void SpawnAsset(Vector2 coordinates)
    {
        asset.transform.position = coordinates; //only translates the prefab that is already in the scene
        
         //Asset newAsset = Instantiate(asset, coordinates, Quaternion.identity) as Asset; //makes multiple copies of a prefab
         
    }
}
