using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFurniture : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private SpriteRenderer spriteFurniture;

    public void ChangeSpriteFurniture(Sprite sprite)
    {
        spriteFurniture.sprite = sprite;
    }

    private void Update()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }
}
