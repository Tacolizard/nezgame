using System;
using Nez;
using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;

namespace nezgame
{
    public class TexLoader : Component
    {
        public Texture2D texture;
        public String path;
        public Scene scene;

        public TexLoader(Scene scene, String path)
        {
            this.path = path;
            this.scene = scene;

            texture = this.scene.content.Load<Texture2D>(this.path);
        }

        public Sprite Sprite()
        {
            return new Sprite(texture);
        }
    }
}
