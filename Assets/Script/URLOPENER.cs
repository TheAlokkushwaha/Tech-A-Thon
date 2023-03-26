using UnityEngine;

public class URLOPENER : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }
}
