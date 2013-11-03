using UnityEngine; 
using System.Collections; 
using System.Xml; 
using System.Xml.Serialization; 
using System.IO; 
using System.Text; 

public class puntuacio : MonoBehaviour {
	
	//private string campText ="Punts: ";
	private int punts=0;
	string rutaFitxer,nomFitxer;
	public Transform explosionPrefab;
	private string campText ="Nom del jugador";
//	public Adioclip audioObertura;
//	public DateTime start;
	DadesPartidaArcanoid dades;
	string objecteSerialitzat; 
	
	// Use this for initialization
	void Start () {
		
		// nom del fitxer
		rutaFitxer=Application.dataPath; 
      	nomFitxer="dades2.xml";
		//crearXML() ;
		
		//dades a desar 
      	dades=new DadesPartidaArcanoid();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		if (GUI.Button(new Rect(120,5,100,20), "Pause"))
		print ("you clicked the button");
		
		GUI.Label(new Rect(5,5,110,20), "Punts: "+punts);
		
		if (!GameObject.Find("bola") && !(GameObject.Find("bola(Clone)"))){
			//print ("dins bola");
			if (!GameObject.Find("bloc")){
				print ("fi blocs");
				GUI.Label(new Rect(5,30,210,50), "Felicitats!! Max Points: "+punts);
				//animacionsGuanyar();
			}else{
				GUI.Label(new Rect(5,30,210,50), "Has perdut i tens "+ punts +" Punts");
				//animacionsPerdre();
			}
			
			campText= GUI.TextField(new Rect(120,50,120,20), campText);
			
			//sobreescriu arxiu pla
			//crear();
			//escriu en linia seguent
			//WriteNWL();
			//guarda 1 resultat en xml
			dades.partida.nom=campText;
			dades.partida.punts=punts;
			objecteSerialitzat = SerialitzarObjecte(dades); 
     		crearXML();
			
			reiniciar();
			
		}else if (!GameObject.Find("bloc")){
			Destroy(GameObject.Find("bola"));
			do{
				Destroy(GameObject.Find("bola(Clone)"));
			}while(GameObject.Find("bola(Clone)"));
		}
	}

	void sumaUnPunt(){
		punts++;
	}
	
	void reiniciar(){
	
		if (GUI.Button(new Rect(5,50,100,20), new GUIContent ("Reiniciar")))
		{
			Application.LoadLevel(1);
		};
	}
	
	void crear() 
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
	//	string s="fds"+DateTime.Now.ToString(); 
	//	string.Format("{0:HH:mm:ss tt}", DateTime.Now);
      writer.Write(""+campText+" ha fet  "+punts+" punts"); 
      writer.Close(); 
      Debug.Log("Fitxer escrit."); 
   } 
	
	// Metode per crear XML
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
      writer.Write(objecteSerialitzat); 
      writer.Close(); 
      Debug.Log("Fitxer escrit."); 
   }
	
	//escriu al final de linia
	public void WriteNWL(){
            StreamReader rnkk = new StreamReader(rutaFitxer+"\\"+ nomFitxer);
            string temp = rnkk.ReadToEnd();
            rnkk.Close();
            StreamWriter rnk = new StreamWriter(rutaFitxer+"\\"+ nomFitxer);
            if (temp == "")
            {
                rnk.Write(""+campText+" ha fet  "+punts+" punts");
            }
            else
            {
                rnk.Write(temp);
                rnk.WriteLine();
                rnk.Write(""+campText+" ha fet  "+punts+" punts");
            }
            rnk.Close();
        }
	
	// serialització de l'objecte
   string SerialitzarObjecte(object pObject){ 
      string XmlizedString = null; 
      MemoryStream memoryStream = new MemoryStream(); 
      XmlSerializer xs = new XmlSerializer(typeof(DadesPartidaArcanoid)); 
      XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8); 
      xs.Serialize(xmlTextWriter, pObject); 
      memoryStream = (MemoryStream)xmlTextWriter.BaseStream; 
      XmlizedString = UTF8ByteArrayToString(memoryStream.ToArray()); 
      return XmlizedString; 
   }
	
	private string UTF8ByteArrayToString(byte[] characters){
            UTF8Encoding encoding = new UTF8Encoding();
            string constructedString = encoding.GetString(characters);
            return (constructedString);
    }
	
}

// Classe a serialitzar del jugador
 public class DadesPartidaArcanoid 
 { 
    // instancia per defecte
   public structDades partida; 
    // constructor per defecte
   public DadesPartidaArcanoid() { } 
 
   // Dades que volem desar en el XML
   public struct structDades 
   { 
    	public int punts; 
    	public string nom; 
		//public DateTime current = DateTime.Now;
   } 
}