using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Tilemap.TilemapObject;

public class Tilemap
{
    public Grid<TilemapObject> grid;
    
    public Tilemap(int width, int height, float cellSize, Vector3 originPosition)
    {
        grid = new Grid<TilemapObject>(width, height, cellSize, originPosition, (Grid<TilemapObject> g, int x, int y) => new TilemapObject(g, x, y));
    }

    public void SetTilemapSprite(Vector3 worldPosition, TilemapObject.TilemapSprite tilemapSprite)
    {
        TilemapObject tilemapObject= grid.GetGridObject(worldPosition);
        if (tilemapObject != null)
        {
            tilemapObject.SetTilemapSprite(tilemapSprite);
        }
    }

    public void SetTilemapSprite(int x, int y, TilemapObject.TilemapSprite tilemapSprite)
    {
        TilemapObject tilemapObject = grid.GetGridObject(x, y);
        if (tilemapObject != null)
        {
            tilemapObject.SetTilemapSprite(tilemapSprite);
        }
    }

    public void SetAllTilemapSprite(TilemapObject.TilemapSprite tilemapSprite)
    {
        for (int x = 0; x < grid.GetWidth(); x++)
        {
            for (int y = 0; y < grid.GetHeight(); y++)
            {
                SetTilemapSprite(x, y, tilemapSprite);
            }
        }
    }

    public void SetTilemapVisual(TilemapVisual tilemapVisual)
    {
        tilemapVisual.SetGrid(grid);
    }

    public void SetIsWalkable()
    {
        for (int x = 0; x < grid.GetWidth(); x++)
        {
            for (int y = 0; y < grid.GetHeight(); y++)
            {
                if(GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(x, y).isWalkable)
                {
                    SetTilemapSprite(x, y, Tilemap.TilemapObject.TilemapSprite.Walkable);
                }
                else
                {
                    SetTilemapSprite(x, y, Tilemap.TilemapObject.TilemapSprite.NotWalkable);
                }
            }
        }
    }
    
    public class TilemapObject
    {
        public enum TilemapSprite
        {
            None,
            Ground,
            Path,
            Dirt,
            Move,
            Walkable,
            NotWalkable,
            Tile1,
            Tile2,
            Tile3,
            Tile4,
            Tile5,
            Tile6,
            Tile7,
            Tile8,
            Tile9,
            Tile10,
            Tile11,
            Tile12,
            Tile13,
            Tile14,
            Tile15,
            Tile16,
            Tile17,
            Tile18,
            Tile19,
            Tile20,
            Tile21,
            Tile22,
            Tile23,
            Tile24,
            Tile25,
            Tile26,
            Tile27,
            Tile28,
            Tile29,
            Tile30,
            Tile31,
            Tile32,
            Tile33,
            Tile34,
            Tile35,
            Tile36,
            Tile37,
            Tile38,
            Tile39,
            Tile40,
            Tile41,
            Tile42,
            Tile43,
            Tile44,
            Tile45,
            Tile46,
            Tile47,
            Tile48,
            Tile49,
            Tile50,
            Tile51,
            Tile52,
            Tile53,
            Tile54,
            Tile55,
            Tile56,
            Tile57,
            Tile58,
            Tile59,
        }

        private Grid<TilemapObject> grid;
        private int x;
        private int y;
        private TilemapSprite tilemapSprite;

        public TilemapObject(Grid<TilemapObject> grid, int x, int y)
        {
            this.grid = grid;
            this.x = x;
            this.y = y;
        }

        public void SetTilemapSprite(TilemapSprite tilemapSprite)
        {
            this.tilemapSprite = tilemapSprite;
            grid.TriggerGridObjectChanged(x, y);
        }

        public TilemapSprite GetTilemapSprite()
        {
            return tilemapSprite;
        }

        public override string ToString()
        {
            return tilemapSprite.ToString();
        }
    }
}
