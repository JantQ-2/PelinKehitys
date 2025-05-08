using System;
using UnityEngine;
using System.IO;
using TMPro;

public class FileManager : MonoBehaviour, IManager
{
     private string dataPath;
     private string textFile;
     private string state;

     public TextMeshProUGUI textComponent;
     public string State
     {
         get { return state; }
         set
         {
             state = value;
         }
     }
     private void Awake()
     {
         // Pysyv� kansio
         dataPath = Application.persistentDataPath + "/Player_Data/";
         // Liikkuva kansio
         //dataPath = Application.dataPath + "/Player_Data/";
         // Tiedoston nimi
         textFile = dataPath + "/Game_Log.txt";
     }
     private void Start()
     {
         Debug.Log("Save path: " + textFile);
         Initialize();
     }
     public void Initialize()
     {
         state = "Tiedostoj�rjestelm� alustettu";
         Debug.Log(state);
         NewDirectory();
         NewTextFile();
         UpdateTextFile($" peli alkoi: {DateTime.Now}\n\n");
         print(ReadFromFile(textFile));
     }
    public void InitializeAgain()
    {
        state = "Tiedostoj�rjestelm� alustettu";
        Debug.Log(state);
        NewDirectory();
        NewTextFile();
        UpdateTextFile($" Pelin Data Poistettiin Ja Aloitettiin Uudestaan: {DateTime.Now}\n\n");
        print(ReadFromFile(textFile));
    }
    private void OnDisable()
     {
         UpdateTextFile($"\n Peli p��ttyi: {DateTime.Now}\n ----------------\n\n");
     }
     // Luo uuden hakemiston, jos sit� ei viel� ole
     public void NewDirectory()
     {
         if (Directory.Exists(dataPath))
         {
             Debug.Log($"{dataPath} hakemisto on jo olemassa!");
             return;
         }
         Directory.CreateDirectory(dataPath);
         Debug.Log("Uusi hakemisto on luotu");
     }
     // Poistaa hakemiston
     public void DeleteDirectory()
     {
         if (!Directory.Exists(dataPath))
         {
             Debug.Log("Hakemistoa ei ole tai se on poistettu");
             return;
         }
         Directory.Delete(dataPath);
         Debug.Log("Hakemisto on poistettu!");
     }
     // Lis�� uusi tiedosto, jos sit� ei viel� ole
     public void NewTextFile()
     {
         if (File.Exists(textFile))
         {
             Debug.Log("Tiedosto on jo olemassa!");
             return;
         }
         File.WriteAllText(textFile, "<TALLETETTU DATA>\n\n");
         Debug.Log("Uusi tiedosto luotu");
     }
     // P�ivit�� tiedoston
     public void UpdateTextFile(string text)
     {
         if (!File.Exists(textFile))
         {
             Debug.Log("Tiedostoa ei l�ydy...");
             return;
         }
         File.AppendAllText(textFile, text);
         Debug.Log("Tiedosto p�ivitetty!");
     }
     // Lukee tiedoston
     public string ReadFromFile(string filename)
     {
         if (!File.Exists(filename))
         {
             Debug.Log("Tiedostoa ei l�ydy...");
             return "";
         }
         return File.ReadAllText(filename);
     }
     // Poistaa tiedoston
     public void DeleteFile(string filename)
     {
         if (!File.Exists(textFile))
         {
             Debug.Log("Tiedostoa ei l�ydy...");
             return;
         }
         UpdateText("<Tallennettu Data>");
         File.Delete(textFile);
         Debug.Log("Tiedosto poistettu!");
     }
     public void UpdateText(string newText)
     {
         if (textComponent != null)
         {
             textComponent.text = newText + "\n";
         }
     }


}