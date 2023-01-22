using UnityEngine;

public class MoreMoney : MonoBehaviour
{
    private bool active = false;

    private float timer;

    [SerializeField]
    private int moreMoney = 5;

    private GetMoney getMoney;

    private void Awake()
    {
        getMoney = FindObjectOfType<GetMoney>();
    }


    public void StartActive()
    {
        timer = 1f;
        active = true;
        gameObject.SetActive(true);
        getMoney.Money += moreMoney;
        getMoney.SetTextAmountmoney();
    }

    private void Update()
    {
        if (active)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                active = false;
                gameObject.SetActive(false);
                timer = 1f;
            }

        }
    }
}
