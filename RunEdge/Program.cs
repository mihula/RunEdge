using System;
using System.Diagnostics;

namespace RunEdge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var uri = String.Join(" ", args);
                if (!String.IsNullOrEmpty(uri))
                {
                    Uri uriResult;
                    if (!(Uri.TryCreate(uri, UriKind.Absolute, out uriResult) && (uriResult != null) && ((uriResult.Scheme == Uri.UriSchemeHttp) || (uriResult.Scheme == Uri.UriSchemeHttps))))
                    {
                        uri = @"http://" + uri;
                    }
                }
                Process.Start($"microsoft-edge:{uri}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
