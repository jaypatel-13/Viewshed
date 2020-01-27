using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public Terrain TerrainMain;
    public void doExit()
    {
        
        //get Terrain height and width
            int xRes = TerrainMain.terrainData.heightmapWidth;
            int yRes = TerrainMain.terrainData.heightmapHeight;
float [,] heights = TerrainMain.terrainData.GetHeights(0,0,xRes,yRes);
          for (int y=0;y<yRes;y++)
                {
                    for(int x=0;x<xRes;x++)
                    {
                        heights[y,x] = 0;
                        //Debug.Log(v + ",");
                    }
                }
                     TerrainMain.terrainData.SetHeights(0,0,heights);
        Application.Quit();
    }
}
