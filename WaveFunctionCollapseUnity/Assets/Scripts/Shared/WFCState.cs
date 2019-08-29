﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WaveFunctionCollapse.Shared
{
    public class WFCState
    {
        public WFCState PreviousState;
        public List<Tile> Tiles;
        public Tile LastUpdatedTile;
        public Sample SetSample;
        public int Step = 0;

        public WFCState(WFCState previousState, List<Tile> tiles, Tile lastUpdatedTile, Sample setSample, int step)
        {
            PreviousState = previousState;
            Tiles = tiles.Clone();
            LastUpdatedTile = lastUpdatedTile.Clone();
            SetSample = setSample;
            Step = step;
        }

        public WFCState(List<Tile> tiles, Tile lastUpdatedTile, Sample setSample, int step)
        {
            // Tiles = tiles.Select(t => t.Clone()).ToList();//CloneTiles(tiles);
            Tiles = tiles.Clone();
            LastUpdatedTile = lastUpdatedTile.Clone();
            SetSample = setSample;
            Step = step;
        }

        //List<Tile> CloneTiles(List<Tile> tilesToClone)
        //{
        //    List<Tile> clonedTiles = new List<Tile>();
        //    for (int i = 0; i < tilesToClone.Count; i++)
        //    {
        //        clonedTiles.Add(tilesToClone[i].Clone());
        //    }
        //    return clonedTiles;
        //}
    }
}
