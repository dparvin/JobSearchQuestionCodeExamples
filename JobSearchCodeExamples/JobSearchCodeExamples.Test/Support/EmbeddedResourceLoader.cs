// Ignore Spelling: Nullable Json

using System.Reflection;
using System.Text.Json;

namespace JobSearchCodeExamples.cs.Test.Support
{
    public static class EmbeddedResourceLoader
    {
        /// <summary>
        /// Loads the nullable int array.
        /// </summary>
        /// <param name="resourceName">Name of the resource.</param>
        /// <returns></returns>
        public static int?[] LoadNullableIntArray(string resourceName) => LoadJson<int?[]>(resourceName);

        /// <summary>
        /// Loads the int array.
        /// </summary>
        /// <param name="resourceName">Name of the resource.</param>
        /// <returns></returns>
        public static int[] LoadIntArray(string resourceName) => LoadJson<int[]>(resourceName);

        /// <summary>
        /// Loads the json.
        /// </summary>
        /// <typeparam name="T">Type to return</typeparam>
        /// <param name="resourceName">Name of the resource.</param>
        /// <returns></returns>
        public static T LoadJson<T>(string resourceName)
        {
            using StreamReader reader = GetStream(resourceName);

            return JsonSerializer.Deserialize<T>(reader.ReadToEnd())
                ?? throw new InvalidOperationException("Unable to deserialize resource.");
        }

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="resourceName">Name of the resource.</param>
        /// <returns></returns>
        private static StreamReader GetStream(string resourceName)
        {
            string[] matches = Assembly
                .GetManifestResourceNames()
                .Where(r => r.EndsWith(resourceName, StringComparison.Ordinal))
                .ToArray();

            if (matches.Length == 0)
                throw new FileNotFoundException(
                    $"Embedded resource '{resourceName}' was not found.\n" +
                    $"Available resources:\n{string.Join(Environment.NewLine, Assembly.GetManifestResourceNames())}");

            if (matches.Length > 1)
                throw new InvalidOperationException(
                    $"Multiple embedded resources match '{resourceName}'.");

            Stream stream = Assembly.GetManifestResourceStream(matches[0])!;
            StreamReader reader = new(stream);

            return reader;
        }

        /// <summary>
        /// The assembly this class is stored in
        /// </summary>
        private static Assembly Assembly = typeof(EmbeddedResourceLoader).Assembly;
    }
}