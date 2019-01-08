namespace TestUnityPackageManager
{
	public static class StringExtensions
	{
		/// <summary>
		/// Checks if a string is null or empty.
		/// </summary>
		/// <param name="str">the string to check, may be null.</param>
		/// <returns>if the string is empty or null.</returns>
		public static bool IsNullOrEmpty(this string str) {
			return string.IsNullOrEmpty(str);
		}
	}
}