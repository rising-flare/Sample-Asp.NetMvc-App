using Microsoft.AspNetCore.Mvc.Rendering;
using SampleApp.Models;
using System.Collections.Generic;

namespace SampleApp.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}