using UnityEngine; 
using System.Collections; 
using System.Xml; 
using System.Xml.Serialization; 
using System.IO; 
using System.Text;



public class guardapunts : MonoBehaviour {
	
	
	string prova="hola mongola";
	string rutaFitxer,nomFitxer; 
	
	// Use this for initialization
	void Start () {
	
		// nom del fitxer
		rutaFitxer=Application.dataPath; 
      	nomFitxer="dades2.xml";
		crearXML() ;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
	
	void crearXML() 
   { 
      StreamWriter writer; 
      FileInfo t = new FileInfo(rutaFitxer+"\\"+ nomFitxer); 
      if(!t.Exists) 
      { 
         writer = t.CreateText(); 
      } 
      else 
      { 
         t.Delete(); 
         writer = t.CreateText(); 
      } 
      writer.Write(prova); 
      writer.Close(); 
      Debug.Log("Fitxer escrit."); 
   } 
 	//metode per carregar XML
   void carregarXML() 
   { 
      StreamReader r = File.OpenText(rutaFitxer+"\\"+ nomFitxer); 
      string _info = r.ReadToEnd(); 
      r.Close(); 
      //objecteSerialitzat=_info; 
      Debug.Log("Fitxer llegit."); 
   } 
	
}
