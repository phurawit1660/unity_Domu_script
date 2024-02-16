using UnityEngine;

public class HoloscopeLove : MonoBehaviour
{
    [Header("HeaderTopic")]
    [SerializeField] GameObject headerTopic;

    [Space(15)]

    [Header("SupTopicRomance")]
    [SerializeField] GameObject subTopicRomance;


    [Space(15)]

    [Header("SupTopicCloseUp")]
    [SerializeField] GameObject subTopicCloseUp;

    [Space(15)]

    [Header("SupTopicPassionate")]
    [SerializeField] GameObject subTopicPassionate;

    [SerializeField] GameObject afterChoose;






    private void Start()
    {
        subTopicCloseUp.SetActive(false);
        subTopicPassionate.SetActive(false);
        subTopicRomance.SetActive(false);

    }


    public void ChoiceHeadTopic(int headTopic)
    {
        switch (headTopic)
        {
            case 0:///ความรักโรแมนติก///

                HoloscopeController.Holo.Add("Love Romantic");

                headerTopic.SetActive(false);
                subTopicRomance.SetActive(true);
                break;
            case 1:///ความรักแบบใกล้ชิด///

                HoloscopeController.Holo.Add("Love Close Up");

                headerTopic.SetActive(false);
                subTopicCloseUp.SetActive(true);


                break;

            case 2:///ความรักแบบหลงใหล///

                HoloscopeController.Holo.Add("Love Passionate");

                headerTopic.SetActive(false);
                subTopicPassionate.SetActive(true);

                break;

        }
    }

    public void SubTopicRomantic(int subTopicRomace)

    {
        switch (subTopicRomace)
        {
            case 0:///โรแมนติกไสตล์ตลาสสิก///

                HoloscopeController.Holo.Add("Romantic Classic");
                subTopicCloseUp.SetActive(false);
                subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;

            case 1:///โรแมนติกไสตล์เพลงแห่งรัก///

                HoloscopeController.Holo.Add("Romantic Music Style");

                subTopicCloseUp.SetActive(false);
                subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;

            case 2:///โรแมนติกไสตล์ภายในแบบส่วนตัว///

                HoloscopeController.Holo.Add("Romantic ");

                subTopicCloseUp.SetActive(false);
                subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;
        }
    }

    public void SubTopicCloseUp(int subTopicCloseUp)

    {
        switch (subTopicCloseUp)
        {
            case 0:///ความรักทางเพื่อน///

                HoloscopeController.Holo.Add("ความรักทางเพื่อน");
                this.subTopicCloseUp.SetActive(false);
                subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;

            case 1:///ความรักครอบครัว///

                HoloscopeController.Holo.Add("ความรักครอบครัว");
                this.subTopicCloseUp.SetActive(false);
                subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;

            case 2:///ความรักแบบยินดีใจ///

                HoloscopeController.Holo.Add("ความรักแบบยินดีใจ");
                this.subTopicCloseUp.SetActive(false);
                subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;
        }
    }

    public void SubTopicPassionate(int subTopicPassionate)

    {
        switch (subTopicPassionate)
        {
            case 0:///ความรักแรกเจอ///

                HoloscopeController.Holo.Add("ความรักแรกเจอ");
                subTopicCloseUp.SetActive(false);
                this.subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;

            case 1:///ความรักแบบคบหาชั่วคราว///

                HoloscopeController.Holo.Add("ความรักแบบคบหาชั่วคราว");
                subTopicCloseUp.SetActive(false);
                this.subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;

            case 2:///ความรักที่เกิดจากการเป็นเพื่อน///

                HoloscopeController.Holo.Add("ความรักที่เกิดจากการเป็นเพื่อน");
                subTopicCloseUp.SetActive(false);
                this.subTopicPassionate.SetActive(false);
                subTopicRomance.SetActive(false);
                afterChoose.SetActive(false);

                break;
        }
    }
    public void Show()
    {
        HoloscopeController.Show();
    }


}







