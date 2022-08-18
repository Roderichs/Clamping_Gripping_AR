using System.Collections;
using UnityEngine;

public class AbrirFacebook : MonoBehaviour
{
    public string Url;
    public void Abrir()
    {
        Application.OpenURL(Url);
    }
}
