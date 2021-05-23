using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

public class MovieService : IMovies{
    private string apiKey = "72d7decec4b08474aef457cd18c51628";
    private readonly HttpClient httpClient;
    public async Task<MovieItem> GetMovieItem(){
        return await httpClient.GetJsonAsync<MovieItem>("https://api.themoviedb.org/3/movie/550?api_key=" + apiKey);
    }
    public async Task<Root> SearchForMovies(string query){
        return await httpClient.GetJsonAsync<Root>("https://api.themoviedb.org/3/search/movie?api_key="+ apiKey +"&query=" + query);
    }
    public MovieService(HttpClient httpClient){
        this.httpClient = httpClient;
    }
}