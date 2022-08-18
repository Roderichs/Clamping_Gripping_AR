using System.Collections;
using UnityEngine;

public class AbrirInstagram : MonoBehaviour
{
    public string Url;
    public void Abrir()
    {
        Application.OpenURL(Url);
    }
}
