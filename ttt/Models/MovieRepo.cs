using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ttt.Models
{
    public class MovieRepo
    {
        public async Task<DiscoverMovie> GetByGenreId(int GenreId)
        {
            var response = await new HttpClient().GetAsync("https://api.themoviedb.org/3/discover/movie?api_key=26cf162ffbd66eae91c236838e871b6f&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_genres="+ GenreId);
            response.EnsureSuccessStatusCode();
            string x = response.Content.ReadAsStringAsync().Result;
            return await Task.Run(() => JsonConvert.DeserializeObject<DiscoverMovie>(x));
        }
    }
}
