using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void UrlHere(string url)
    {
        Application.OpenURL(url);
    }
}
