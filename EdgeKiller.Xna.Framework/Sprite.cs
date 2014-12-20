using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace EdgeKiller.Xna.Framework
{
    public class Sprite
    {
        private int x = 0, y = 0, width = 0, height = 0;
        private Texture2D texture = null;
        private Color color = Color.White;

        public Sprite(Texture2D texture)
        {
            this.x = 0;
            this.y = 0;
            this.width = texture.Width;
            this.height = texture.Height;
            this.texture = texture;
        }

        public Sprite(Texture2D texture, int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.texture = texture;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void SetTexture(Texture2D texture, int width, int height)
        {
            this.texture = texture;
            this.width = width;
            this.height = height;
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(x, y, width, height);
        }

        public Texture2D GetTexture()
        {
            return texture;
        }

        public int GetX() 
        {
            return x; 
        }

        public int GetY()
        {
            return y;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Draw(this.texture, this.GetRectangle(), this.color);
        }
    }
      

    
}
