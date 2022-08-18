using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idioma : MonoBehaviour
{
    public int CambioIdioma = 1;
    public string[] TextoIngles;
    public string[] TextoEspañol;
    public Text[] Text;

    void Update()
    {
        CambioIdioma = PlayerPrefs.GetInt("Idioma");
        if(CambioIdioma == 0){
            IdiomaIngles();
        }else if(CambioIdioma == 1){
            IdiomaEspañol();
        }
    }

    public void Cambiar(){
        if(CambioIdioma == 0){
            CambioIdioma = 1;
            PlayerPrefs.SetInt("Idioma", CambioIdioma);
            PlayerPrefs.Save();
        }else if(CambioIdioma == 1){
            CambioIdioma = 0;
            PlayerPrefs.SetInt("Idioma", CambioIdioma);
            PlayerPrefs.Save();
        }
    }

    void IdiomaIngles(){
        if(Text[0] != null){
            Text[0].text = TextoIngles[0];
        }
        if(Text[1] != null){
            Text[1].text = TextoIngles[1];
        }
        if(Text[2] != null){
            Text[2].text = TextoIngles[2];
        }
        if(Text[3] != null){
            Text[3].text = TextoIngles[3];
        }
        if(Text[4] != null){
            Text[4].text = TextoIngles[4];
        }
        if(Text[5] != null){
            Text[5].text = TextoIngles[5];
        }
        if(Text[6] != null){
            Text[6].text = TextoIngles[6];
        }
        if(Text[7] != null){
            Text[7].text = TextoIngles[7];
        }
        if(Text[8] != null){
            Text[8].text = TextoIngles[8];
        }
        if(Text[9] != null){
            Text[9].text = TextoIngles[9];
        }
        if(Text[10] != null){
            Text[10].text = TextoIngles[10];
        }
        if(Text[11] != null){
            Text[11].text = TextoIngles[11];
        }
        if(Text[12] != null){
            Text[12].text = TextoIngles[12];
        }
        if(Text[13] != null){
            Text[13].text = TextoIngles[13];
        }
        if(Text[14] != null){
            Text[14].text = TextoIngles[14];
        }
        if(Text[15] != null){
            Text[15].text = TextoIngles[15];
        }
        if(Text[16] != null){
            Text[16].text = TextoIngles[16];
        }
        if(Text[17] != null){
            Text[17].text = TextoIngles[17];
        }
        if(Text[18] != null){
            Text[18].text = TextoIngles[18];
        }
        if(Text[19] != null){
            Text[19].text = TextoIngles[19];
        }
        if(Text[20] != null){
            Text[20].text = TextoIngles[20];
        }
        if(Text[21] != null){
            Text[21].text = TextoIngles[21];
        }
        if(Text[22] != null){
            Text[22].text = TextoIngles[22];
        }
        if(Text[23] != null){
            Text[23].text = TextoIngles[23];
        }
        if(Text[24] != null){
            Text[24].text = TextoIngles[24];
        }
        if(Text[25] != null){
            Text[25].text = TextoIngles[25];
        }
        if(Text[26] != null){
            Text[26].text = TextoIngles[26];
        }
        if(Text[27] != null){
            Text[27].text = TextoIngles[27];
        }
        if(Text[28] != null){
            Text[28].text = TextoIngles[28];
        }
        if(Text[29] != null){
            Text[29].text = TextoIngles[29];
        }
        if(Text[30] != null){
            Text[30].text = TextoIngles[30];
        }
        if(Text[31] != null){
            Text[31].text = TextoIngles[31];
        }
        if(Text[32] != null){
            Text[32].text = TextoIngles[32];
        }
        if(Text[33] != null){
            Text[33].text = TextoIngles[33];
        }
        if(Text[34] != null){
            Text[34].text = TextoIngles[34];
        }
        if(Text[35] != null){
            Text[35].text = TextoIngles[35];
        }
        if(Text[36] != null){
            Text[36].text = TextoIngles[36];
        }
        if(Text[37] != null){
            Text[37].text = TextoIngles[37];
        }
        if(Text[38] != null){
            Text[38].text = TextoIngles[38];
        }
        if(Text[39] != null){
            Text[39].text = TextoIngles[39];
        }
        if(Text[40] != null){
            Text[40].text = TextoIngles[40];
        }
        if(Text[41] != null){
            Text[41].text = TextoIngles[41];
        }
        if(Text[42] != null){
            Text[42].text = TextoIngles[42];
        }
        if(Text[43] != null){
            Text[43].text = TextoIngles[43];
        }
        if(Text[44] != null){
            Text[44].text = TextoIngles[44];
        }
        if(Text[45] != null){
            Text[45].text = TextoIngles[45];
        }
        if(Text[46] != null){
            Text[46].text = TextoIngles[46];
        }
        if(Text[47] != null){
            Text[47].text = TextoIngles[47];
        }
        if(Text[48] != null){
            Text[48].text = TextoIngles[48];
        }
        if(Text[49] != null){
            Text[49].text = TextoIngles[49];
        }
        if(Text[50] != null){
            Text[50].text = TextoIngles[50];
        }
        if(Text[51] != null){
            Text[51].text = TextoIngles[51];
        }
        if(Text[52] != null){
            Text[52].text = TextoIngles[52];
        }
        if(Text[53] != null){
            Text[53].text = TextoIngles[53];
        }
        if(Text[54] != null){
            Text[54].text = TextoIngles[54];
        }
        if(Text[55] != null){
            Text[55].text = TextoIngles[55];
        }
        if(Text[56] != null){
            Text[56].text = TextoIngles[56];
        }
        if(Text[57] != null){
            Text[57].text = TextoIngles[57];
        }
        if(Text[58] != null){
            Text[58].text = TextoIngles[58];
        }
        if(Text[59] != null){
            Text[59].text = TextoIngles[59];
        }
        if(Text[60] != null){
            Text[60].text = TextoIngles[60];
        }
        if(Text[61] != null){
            Text[61].text = TextoIngles[61];
        }
        if(Text[62] != null){
            Text[62].text = TextoIngles[62];
        }
        if(Text[63] != null){
            Text[63].text = TextoIngles[63];
        }
        if(Text[64] != null){
            Text[64].text = TextoIngles[64];
        }
        if(Text[65] != null){
            Text[65].text = TextoIngles[65];
        }
        if(Text[66] != null){
            Text[66].text = TextoIngles[66];
        }
        if(Text[67] != null){
            Text[67].text = TextoIngles[67];
        }
        if(Text[68] != null){
            Text[68].text = TextoIngles[68];
        }
        if(Text[69] != null){
            Text[69].text = TextoIngles[69];
        }
        if(Text[70] != null){
            Text[70].text = TextoIngles[70];
        }
        if(Text[71] != null){
            Text[71].text = TextoIngles[71];
        }
        if(Text[72] != null){
            Text[72].text = TextoIngles[72];
        }
        if(Text[73] != null){
            Text[73].text = TextoIngles[73];
        }
        if(Text[74] != null){
            Text[74].text = TextoIngles[74];
        }
        if(Text[75] != null){
            Text[75].text = TextoIngles[75];
        }
        if(Text[76] != null){
            Text[76].text = TextoIngles[76];
        }
        if(Text[77] != null){
            Text[77].text = TextoIngles[77];
        }
        if(Text[78] != null){
            Text[78].text = TextoIngles[78];
        }
        if(Text[79] != null){
            Text[79].text = TextoIngles[79];
        }
        if(Text[80] != null){
            Text[80].text = TextoIngles[80];
        }
        if(Text[81] != null){
            Text[81].text = TextoIngles[81];
        }
        if(Text[82] != null){
            Text[82].text = TextoIngles[82];
        }
        if(Text[83] != null){
            Text[83].text = TextoIngles[83];
        }
        if(Text[84] != null){
            Text[84].text = TextoIngles[84];
        }
        if(Text[85] != null){
            Text[85].text = TextoIngles[85];
        }
        if(Text[86] != null){
            Text[86].text = TextoIngles[86];
        }
        if(Text[87] != null){
            Text[87].text = TextoIngles[87];
        }
        if(Text[88] != null){
            Text[88].text = TextoIngles[88];
        }
        if(Text[89] != null){
            Text[89].text = TextoIngles[89];
        }
    }

    void IdiomaEspañol(){
        if(Text[0] != null){
            Text[0].text = TextoEspañol[0];
        }
        if(Text[1] != null){
            Text[1].text = TextoEspañol[1];
        }
        if(Text[2] != null){
            Text[2].text = TextoEspañol[2];
        }
        if(Text[3] != null){
            Text[3].text = TextoEspañol[3];
        }
        if(Text[4] != null){
            Text[4].text = TextoEspañol[4];
        }
        if(Text[5] != null){
            Text[5].text = TextoEspañol[5];
        }
        if(Text[6] != null){
            Text[6].text = TextoEspañol[6];
        }
        if(Text[7] != null){
            Text[7].text = TextoEspañol[7];
        }
        if(Text[8] != null){
            Text[8].text = TextoEspañol[8];
        }
        if(Text[9] != null){
            Text[9].text = TextoEspañol[9];
        }
        if(Text[10] != null){
            Text[10].text = TextoEspañol[10];
        }
        if(Text[11] != null){
            Text[11].text = TextoEspañol[11];
        }
        if(Text[12] != null){
            Text[12].text = TextoEspañol[12];
        }
        if(Text[13] != null){
            Text[13].text = TextoEspañol[13];
        }
        if(Text[14] != null){
            Text[14].text = TextoEspañol[14];
        }
        if(Text[15] != null){
            Text[15].text = TextoEspañol[15];
        }
        if(Text[16] != null){
            Text[16].text = TextoEspañol[16];
        }
        if(Text[17] != null){
            Text[17].text = TextoEspañol[17];
        }
        if(Text[18] != null){
            Text[18].text = TextoEspañol[18];
        }
        if(Text[19] != null){
            Text[19].text = TextoEspañol[19];
        }
        if(Text[20] != null){
            Text[20].text = TextoEspañol[20];
        }
        if(Text[21] != null){
            Text[21].text = TextoEspañol[21];
        }
        if(Text[22] != null){
            Text[22].text = TextoEspañol[22];
        }
        if(Text[23] != null){
            Text[23].text = TextoEspañol[23];
        }
        if(Text[24] != null){
            Text[24].text = TextoEspañol[24];
        }
        if(Text[25] != null){
            Text[25].text = TextoEspañol[25];
        }
        if(Text[26] != null){
            Text[26].text = TextoEspañol[26];
        }
        if(Text[27] != null){
            Text[27].text = TextoEspañol[27];
        }
        if(Text[28] != null){
            Text[28].text = TextoEspañol[28];
        }
        if(Text[29] != null){
            Text[29].text = TextoEspañol[29];
        }
        if(Text[30] != null){
            Text[30].text = TextoEspañol[30];
        }
        if(Text[31] != null){
            Text[31].text = TextoEspañol[31];
        }
        if(Text[32] != null){
            Text[32].text = TextoEspañol[32];
        }
        if(Text[33] != null){
            Text[33].text = TextoEspañol[33];
        }
        if(Text[34] != null){
            Text[34].text = TextoEspañol[34];
        }
        if(Text[35] != null){
            Text[35].text = TextoEspañol[35];
        }
        if(Text[36] != null){
            Text[36].text = TextoEspañol[36];
        }
        if(Text[37] != null){
            Text[37].text = TextoEspañol[37];
        }
        if(Text[38] != null){
            Text[38].text = TextoEspañol[38];
        }
        if(Text[39] != null){
            Text[39].text = TextoEspañol[39];
        }
        if(Text[40] != null){
            Text[40].text = TextoEspañol[40];
        }
        if(Text[41] != null){
            Text[41].text = TextoEspañol[41];
        }
        if(Text[42] != null){
            Text[42].text = TextoEspañol[42];
        }
        if(Text[43] != null){
            Text[43].text = TextoEspañol[43];
        }
        if(Text[44] != null){
            Text[44].text = TextoEspañol[44];
        }
        if(Text[45] != null){
            Text[45].text = TextoEspañol[45];
        }
        if(Text[46] != null){
            Text[46].text = TextoEspañol[46];
        }
        if(Text[47] != null){
            Text[47].text = TextoEspañol[47];
        }
        if(Text[48] != null){
            Text[48].text = TextoEspañol[48];
        }
        if(Text[49] != null){
            Text[49].text = TextoEspañol[49];
        }
        if(Text[50] != null){
            Text[50].text = TextoEspañol[50];
        }
        if(Text[51] != null){
            Text[51].text = TextoEspañol[51];
        }
        if(Text[52] != null){
            Text[52].text = TextoEspañol[52];
        }
        if(Text[53] != null){
            Text[53].text = TextoEspañol[53];
        }
        if(Text[54] != null){
            Text[54].text = TextoEspañol[54];
        }
        if(Text[55] != null){
            Text[55].text = TextoEspañol[55];
        }
        if(Text[56] != null){
            Text[56].text = TextoEspañol[56];
        }
        if(Text[57] != null){
            Text[57].text = TextoEspañol[57];
        }
        if(Text[58] != null){
            Text[58].text = TextoEspañol[58];
        }
        if(Text[59] != null){
            Text[59].text = TextoEspañol[59];
        }
        if(Text[60] != null){
            Text[60].text = TextoEspañol[60];
        }
        if(Text[61] != null){
            Text[61].text = TextoEspañol[61];
        }
        if(Text[62] != null){
            Text[62].text = TextoEspañol[62];
        }
        if(Text[63] != null){
            Text[63].text = TextoEspañol[63];
        }
        if(Text[64] != null){
            Text[64].text = TextoEspañol[64];
        }
        if(Text[65] != null){
            Text[65].text = TextoEspañol[65];
        }
        if(Text[66] != null){
            Text[66].text = TextoEspañol[66];
        }
        if(Text[67] != null){
            Text[67].text = TextoEspañol[67];
        }
        if(Text[68] != null){
            Text[68].text = TextoEspañol[68];
        }
        if(Text[69] != null){
            Text[69].text = TextoEspañol[69];
        }
        if(Text[70] != null){
            Text[70].text = TextoEspañol[70];
        }
        if(Text[71] != null){
            Text[71].text = TextoEspañol[71];
        }
        if(Text[72] != null){
            Text[72].text = TextoEspañol[72];
        }
        if(Text[73] != null){
            Text[73].text = TextoEspañol[73];
        }
        if(Text[74] != null){
            Text[74].text = TextoEspañol[74];
        }
        if(Text[75] != null){
            Text[75].text = TextoEspañol[75];
        }
        if(Text[76] != null){
            Text[76].text = TextoEspañol[76];
        }
        if(Text[77] != null){
            Text[77].text = TextoEspañol[77];
        }
        if(Text[78] != null){
            Text[78].text = TextoEspañol[78];
        }
        if(Text[79] != null){
            Text[79].text = TextoEspañol[79];
        }
        if(Text[80] != null){
            Text[80].text = TextoEspañol[80];
        }
        if(Text[81] != null){
            Text[81].text = TextoEspañol[81];
        }
        if(Text[82] != null){
            Text[82].text = TextoEspañol[82];
        }
        if(Text[83] != null){
            Text[83].text = TextoEspañol[83];
        }
        if(Text[84] != null){
            Text[84].text = TextoEspañol[84];
        }
        if(Text[85] != null){
            Text[85].text = TextoEspañol[85];
        }
        if(Text[86] != null){
            Text[86].text = TextoEspañol[86];
        }
        if(Text[87] != null){
            Text[87].text = TextoEspañol[87];
        }
        if(Text[88] != null){
            Text[88].text = TextoEspañol[88];
        }
        if(Text[89] != null){
            Text[89].text = TextoEspañol[89];
        }
    }
}
