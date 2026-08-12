using System.Runtime.CompilerServices;

namespace WarehouseManager {

	internal static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			RuntimeHelpers.RunClassConstructor(typeof(FileManager).TypeHandle);
			RuntimeHelpers.RunClassConstructor(typeof(Users).TypeHandle);
			RuntimeHelpers.RunClassConstructor(typeof(Products).TypeHandle);
			Application.Run(new FormLogin());
		}
	}
}