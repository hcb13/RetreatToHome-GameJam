using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateOptionsFurniture : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabOptionUI;

    [SerializeField]
    private List<Texture2D> imagesFurnitures;

    [SerializeField]
    private GameObject contentPanel;


    private void Awake()
    {
        InstantiateOptionsFurniture();
    }

    private void InstantiateOptionsFurniture()
    {
        foreach(Texture2D image in imagesFurnitures)
        {
            GameObject option = Instantiate(prefabOptionUI, contentPanel.transform.position, Quaternion.identity, contentPanel.transform);
            option.GetComponent<OptionFurniture>().SetImageFurniture(image);
            option.GetComponent<OptionFurniture>().SetSpriteFurniture(image);
        }
    }
}
