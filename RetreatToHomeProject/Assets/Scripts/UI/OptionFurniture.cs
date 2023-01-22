using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OptionFurniture : MonoBehaviour
{
    [SerializeField]
    private RawImage imageFurniture;

    private Sprite spriteFurniture;

    private GetFurniture getFurnitureSelected;

    public Action<Sprite> OnGetSprite = delegate { };

    private void Awake()
    {
        getFurnitureSelected = GameObject.FindObjectOfType<GetFurniture>();
        OnGetSprite += getFurnitureSelected.ChangeSpriteFurniture;
    }

    public void SetImageFurniture(Texture2D texture)
    {
        imageFurniture.texture = texture;
    }

    public void SetSpriteFurniture(Texture2D texture)
    {
        spriteFurniture = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }

    public void GetSprite()
    {
        OnGetSprite?.Invoke(spriteFurniture);
    }
}
