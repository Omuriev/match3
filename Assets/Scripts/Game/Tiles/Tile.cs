using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Game.Tiles
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Tile : MonoBehaviour
    {
        public TileConfig TileConfig { get; private set; }
        public bool IsInteractable { get; private set; }
        public bool IsMatched { get; private set; }

        public void SetTileConfig(TileConfig tileConfig)
        {
            TileConfig = tileConfig;
            IsInteractable = tileConfig.IsInteractable;
            IsMatched = false;
            GetComponent<SpriteRenderer>().sprite = tileConfig.Sprite;
        }

        public bool SetMatch(bool value) => IsMatched = value;
    }
}
