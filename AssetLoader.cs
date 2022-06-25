using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;


namespace Core
{
    public static class AssetLoader
    {
        private static ContentManager _content;

        public static void Init(ContentManager _contentManager)
        {
            _content = _contentManager;
        }

        public static Texture2D GetTexture(string _name) => _content.Load<Texture2D>(_name);
        public static SpriteFont GetFont(string _name) => _content.Load<SpriteFont>(_name);
        public static SoundEffect GetSFX(string _name) => _content.Load<SoundEffect>(_name);

    }
}
