using UnityEngine;

public class GetMoney : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI textAmountMoney;

    private int money = 75;
    public int Money
    {
        get { return money; }
        set { money = value; }
    }

    private void Awake()
    {
        SetTextAmountmoney();
    }

    public void SetTextAmountmoney()
    {
        textAmountMoney.text = money.ToString();
    }
}
