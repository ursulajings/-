using UnityEngine;
using UnityEngine.UI;

public class DelayAppear : MonoBehaviour
{
    public Image picture1;
    public Image picture2;
    public Image picture3;
    public Image picture4;

    private void Start()
    {
        picture1.gameObject.SetActive(false);
        picture2.gameObject.SetActive(false);
        picture3.gameObject.SetActive(false);
        picture4.gameObject.SetActive(false);


        Invoke("AppearPicture1", 1f);
        Invoke("AppearPicture2", 2f);
        Invoke("AppearPicture3", 3f);
        Invoke("AppearPicture4", 4f);
    }

    private void AppearPicture1()
    {
        picture1.gameObject.SetActive(true);

    }

    private void AppearPicture2()
    {
        picture2.gameObject.SetActive(true);

    }

    private void AppearPicture3()
    {
        picture3.gameObject.SetActive(true);

    }

    private void AppearPicture4()
    {
        picture4.gameObject.SetActive(true);

    }
}