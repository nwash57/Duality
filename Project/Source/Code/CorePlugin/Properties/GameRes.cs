/*
 * A set of static helper classes that provide easy runtime access to the games resources.
 * This file is auto-generated. Any changes made to it are lost as soon as Duality decides
 * to regenerate it.
 */
namespace GameRes
{
	public static class Data {
		public static Duality.ContentRef<Duality.Resources.Scene> Scene_Scene { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Scene>(@"Data\Scene.Scene.res"); }}
		public static Duality.ContentRef<Duality.Resources.Material> ShipOne_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\ShipOne.Material.res"); }}
		public static Duality.ContentRef<Duality.Resources.Pixmap> ShipOne_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\ShipOne.Pixmap.res"); }}
		public static Duality.ContentRef<Duality.Resources.Texture> ShipOne_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\ShipOne.Texture.res"); }}
		public static Duality.ContentRef<Duality.Resources.Material> SpaceBg_Material { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Material>(@"Data\SpaceBg.Material.res"); }}
		public static Duality.ContentRef<Duality.Resources.Pixmap> SpaceBg_Pixmap { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Pixmap>(@"Data\SpaceBg.Pixmap.res"); }}
		public static Duality.ContentRef<Duality.Resources.Texture> SpaceBg_Texture { get { return Duality.ContentProvider.RequestContent<Duality.Resources.Texture>(@"Data\SpaceBg.Texture.res"); }}
		public static void LoadAll() {
			Scene_Scene.MakeAvailable();
			ShipOne_Material.MakeAvailable();
			ShipOne_Pixmap.MakeAvailable();
			ShipOne_Texture.MakeAvailable();
			SpaceBg_Material.MakeAvailable();
			SpaceBg_Pixmap.MakeAvailable();
			SpaceBg_Texture.MakeAvailable();
		}
	}

}
