using System.Collections;
using UnityEngine;

public class AbrirLinkedIn : MonoBehaviour
{
    public string Url;
    public void Abrir()
    {
        Application.OpenURL(Url);
    }
}
