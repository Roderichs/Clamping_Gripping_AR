using System.Collections;
using UnityEngine;

public class AbrirXING : MonoBehaviour
{
    public string Url;
    public void Abrir()
    {
        Application.OpenURL(Url);
    }
}
