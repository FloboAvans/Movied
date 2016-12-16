using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.TMDb;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;

namespace MoviedApp
{
    class MovieApiCalls
    {
        //private static string apiKey;
        //private ServiceClient client;
        private static Movies mostPopularMovies;
        private static Movie movie;
        private static string apiKey = Constants.Apis.TheMovieDatabase.API_KEY;

        public MovieApiCalls(string apiKey)
        {
            getPopularMoviesTask();
        }

        static async Task getPopularMoviesTask()
        {
            var client = new ServiceClient(apiKey);
            mostPopularMovies = await client.Movies.GetPopularAsync(null, 1, new CancellationToken(false));
        }

        static async Task getMovie(int movieID)
        {
            var client = new ServiceClient(apiKey);
            movie = await client.Movies.GetAsync(movieID, null, true, new CancellationToken(false));
        }

        public Movies getPopularMovies()
        {
            return mostPopularMovies;
        }
    }
}
