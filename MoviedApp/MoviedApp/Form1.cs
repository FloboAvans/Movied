using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.TMDb;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sample(new CancellationToken(false));
        }

        static async Task Sample(CancellationToken cancellationToken)
        {
            using (var client = new ServiceClient("c84acd026332c3ab0c37200ff32e6f07"))
            {
                for (int i = 1, count = 20; i <= count; i++)
                {
                    var movies = await client.Movies.GetPopularAsync(null, i, cancellationToken);
                    //Console.WriteLine("Top movies:");
                    //foreach (var movie in movies.Results)
                    //{
                    //  Console.WriteLine("\t"+movie.Title);
                    //}
                    count = movies.PageCount; // keep track of the actual page count
                    Console.WriteLine("---Most Popular Movies");
                    foreach (Movie m in movies.Results)
                    {
                        var movie = await client.Movies.GetAsync(m.Id, null, true, cancellationToken);
                        Console.WriteLine("\t" + movie.Title);
                        var personIds = movie.Credits.Cast.Select(s => s.Id)
                            .Union(movie.Credits.Crew.Select(s => s.Id));

                        string filepath = Path.Combine("People", movie.Images.Posters.First().FilePath.TrimStart('/'));
                        await DownloadImage(movie.Images.Posters.First().FilePath, filepath, cancellationToken);
                        Console.WriteLine("\t\t" + filepath);
                        //foreach (var id in personIds)
                        //{
                        //    var person = await client.People.GetAsync(id, true, cancellationToken);
                        //   // Console.WriteLine("\t\t" + person.Name);
                        //    foreach (var img in person.Images.Results)
                        //    {
                        //        //string filepath = Path.Combine("People", img.FilePath.TrimStart('/'));
                        //        //await DownloadImage(img.FilePath, filepath, cancellationToken);
                        //        //Console.WriteLine("\t\t\t" + filepath);
                        //    }
                        //}
                    }
                    
                }
            }
        }

        static async Task DownloadImage(string filename, string localpath, CancellationToken cancellationToken)
        {
            if (!File.Exists(localpath))
            {
                string folder = Path.GetDirectoryName(localpath);
                Directory.CreateDirectory(folder);

                var storage = new StorageClient();
                using (var fileStream = new FileStream(localpath, FileMode.Create,
                    FileAccess.Write, FileShare.None, short.MaxValue, true))
                {
                    try { await storage.DownloadAsync(filename, fileStream, cancellationToken); }
                    catch (Exception ex) { System.Diagnostics.Trace.TraceError(ex.ToString()); }
                }
            }
        }
    }
}
