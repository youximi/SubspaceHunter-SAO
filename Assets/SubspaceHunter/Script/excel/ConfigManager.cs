using GameConfig;
using Luban;
using UnityEngine;



    public static class GameConfigMgr
    {
        private static Tables _tables;
        public static Tables Tables => _tables;

        public static void Load()
        {
            _tables = new Tables(LoadByteBuf);
        }

        /// <summary>
        /// 加载二进制配置。
        /// </summary>
        /// <param name="file">FileName</param>
        /// <returns>ByteBuf</returns>
        private static ByteBuf LoadByteBuf(string file)
        {
            TextAsset textAsset = Resources.Load<TextAsset>("Configs/bytes/"+file);
            byte[] bytes = textAsset.bytes;
            Resources.UnloadAsset(textAsset);
            return new ByteBuf(bytes);
        }

    }
