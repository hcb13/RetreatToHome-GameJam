using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutFurniture : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private GameObject prefabSprite;

    private bool canAddFurniture;

    private GetFurniture furniture;

    private void Awake()
    {
        furniture = FindObjectOfType<GetFurniture>();
        furniture.OnMouseButtonDown += AddFurniture;

        Physics2D.queriesHitTriggers = true;
    }

    private void OnMouseOver()
    {
        canAddFurniture = true;
    }

    private void OnMouseExit()
    {
        canAddFurniture = false;
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }

    private void AddFurniture(Sprite sprite)
    {
        if (canAddFurniture)
        {
            GameObject furniture = Instantiate(prefabSprite, GetMousePosition(), Quaternion.identity, transform);
            furniture.GetComponent<SpriteRenderer>().sprite = sprite;
            FindObjectOfType<GetFurniture>().CleanMouse();
        }
    }


}
