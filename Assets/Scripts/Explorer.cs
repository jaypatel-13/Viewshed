using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using SmartDLL;

public class Explorer : MonoBehaviour
{
    public Text eText;
    public Button openExplorerButton;
    public Terrain TerrainMain;

    public SmartFileExplorer fileExplorer = new SmartFileExplorer();

    private bool readText = false;

    void OnEnable()
    {
        openExplorerButton.onClick.AddListener(delegate{ShowExplorer();});
        Debug.Log("Explorer opened");
    }

    void Start()
    {

    }

    void Update()
    {
        if(fileExplorer.resultOK && readText)
        {
            ReadText(fileExplorer.fileName);
            Debug.Log("update");
            readText = false;
        }
    }

    void ShowExplorer()
    {
        string initialDir = @"C:\";
        bool restoreDir = true;
        string title = "Open a file";
        string defExt = "raw";
        string filter = "Raw file |*.raw";

        Debug.Log("ShowExplorer()");

        fileExplorer.OpenExplorer(initialDir,restoreDir,title,defExt,filter);
        readText = true;    
    }

    void ReadText(string aFileName)
    {
        int xRes = TerrainMain.terrainData.heightmapWidth;
        int yRes = TerrainMain.terrainData.heightmapHeight;

            

            //GetHeight - get the heightmap point of terrain
            float [,] heights = TerrainMain.terrainData.GetHeights(0,0,xRes,yRes);

            //Manipulate the heigth data
            using (var file = System.IO.File.OpenRead(aFileName))
            using (var reader = new System.IO.BinaryReader(file))
            {
                for (int y=0;y<yRes;y++)
                {
                    for(int x=0;x<xRes;x++)
                    {
                        float v = (float)reader.ReadByte();
                        heights[y,x] = v / 1024f;
                        //Debug.Log(v + ",");
                    }
                }
            }
            TerrainMain.terrainData.SetHeights(0,0,heights);

    }
}
