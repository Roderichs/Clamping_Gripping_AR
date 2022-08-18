using System.Collections;
using UnityEngine;

public class AbrirTwitter : MonoBehaviour
{
    public string Url;
    public void Abrir()
    {
         Application.OpenURL(Url);
    }
}
