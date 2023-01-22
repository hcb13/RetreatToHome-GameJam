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

    [SerializeField]
    private TMPro.TextMeshProUGUI textPrice;

    [SerializeField]
    private int price;
    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    private Sprite spriteFurniture;

    private GetFurniture getFurnitureSelected;

    private GetMoney getMoney;

    public Action<Sprite> OnGetSprite = delegate { };

    private void Awake()
    {
        textPrice.text = "$ " + price.ToString();
        
        getFurnitureSelected = GameObject.FindObjectOfType<GetFurniture>();                
        OnGetSprite += getFurnitureSelected.ChangeSpriteFurniture;

        getMoney = GameObject.FindObjectOfType<GetMoney>();
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
        if (price <= getMoney.Money)
        {
            getMoney.Money -= price;
            getMoney.SetTextAmountmoney();

            OnGetSprite?.Invoke(spriteFurniture);
        }
    }
}
