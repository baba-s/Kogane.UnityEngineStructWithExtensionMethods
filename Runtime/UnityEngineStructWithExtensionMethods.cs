using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// Vector3 や Color などの特定の要素のみを変更したインスタンスを返す拡張メソッド
    /// </summary>
    public static class UnityEngineStructWithExtensionMethods
    {
        /// <summary>
        /// X 座標のみを変更した Vector2 を返します
        /// </summary>
        public static Vector2 WithX( this Vector2 self, float x ) => new( x, self.y );

        /// <summary>
        /// Y 座標のみを変更した Vector2 を返します
        /// </summary>
        public static Vector2 WithY( this Vector2 self, float y ) => new( self.x, y );

        /// <summary>
        /// X 座標のみを変更した Vector2Int を返します
        /// </summary>
        public static Vector2Int WithX( this Vector2Int self, int x ) => new( x, self.y );

        /// <summary>
        /// Y 座標のみを変更した Vector2Int を返します
        /// </summary>
        public static Vector2Int WithY( this Vector2Int self, int y ) => new( self.x, y );

        /// <summary>
        /// X 座標のみを変更した Vector3 を返します
        /// </summary>
        public static Vector3 WithX( this Vector3 self, float x ) => new( x, self.y, self.z );

        /// <summary>
        /// Y 座標のみを変更した Vector3 を返します
        /// </summary>
        public static Vector3 WithY( this Vector3 self, float y ) => new( self.x, y, self.z );

        /// <summary>
        /// Z 座標のみを変更した Vector3 を返します
        /// </summary>
        public static Vector3 WithZ( this Vector3 self, float z ) => new( self.x, self.y, z );

        /// <summary>
        /// X 座標のみを変更した Vector3Int を返します
        /// </summary>
        public static Vector3Int WithX( this Vector3Int self, int x ) => new( x, self.y, self.z );

        /// <summary>
        /// Y 座標のみを変更した Vector3Int を返します
        /// </summary>
        public static Vector3Int WithY( this Vector3Int self, int y ) => new( self.x, y, self.z );

        /// <summary>
        /// Z 座標のみを変更した Vector3Int を返します
        /// </summary>
        public static Vector3Int WithZ( this Vector3Int self, int z ) => new( self.x, self.y, z );

        /// <summary>
        /// R 値のみを変更した Color を返します
        /// </summary>
        public static Color WithR( this Color self, float r ) => new( r, self.g, self.b, self.a );

        /// <summary>
        /// G 値のみを変更した Color を返します
        /// </summary>
        public static Color WithG( this Color self, float g ) => new( self.r, g, self.b, self.a );

        /// <summary>
        /// B 値のみを変更した Color を返します
        /// </summary>
        public static Color WithB( this Color self, float b ) => new( self.r, self.g, b, self.a );

        /// <summary>
        /// A 値のみを変更した Color を返します
        /// </summary>
        public static Color WithA( this Color self, float a ) => new( self.r, self.g, self.b, a );

        /// <summary>
        /// R 値のみを変更した Color32 を返します
        /// </summary>
        public static Color32 WithR( this Color32 self, byte r ) => new( r, self.g, self.b, self.a );

        /// <summary>
        /// G 値のみを変更した Color32 を返します
        /// </summary>
        public static Color32 WithG( this Color32 self, byte g ) => new( self.r, g, self.b, self.a );

        /// <summary>
        /// B 値のみを変更した Color32 を返します
        /// </summary>
        public static Color32 WithB( this Color32 self, byte b ) => new( self.r, self.g, b, self.a );

        /// <summary>
        /// A 値のみを変更した Color32 を返します
        /// </summary>
        public static Color32 WithA( this Color32 self, byte a ) => new( self.r, self.g, self.b, a );
    }
}