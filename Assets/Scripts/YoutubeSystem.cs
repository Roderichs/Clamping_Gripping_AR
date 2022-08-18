using System.Collections;
using UnityEngine;

public class YoutubeSystem : MonoBehaviour
{
    public string Url;
    public void Abrir()
    {
       Application.OpenURL(Url); 
    }
}
