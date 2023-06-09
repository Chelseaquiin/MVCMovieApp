﻿
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCMovie.Models;

public class MovieGenreVM
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}


