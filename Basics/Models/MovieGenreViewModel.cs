using Basics.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Basics.Models;

public class MovieGenreViewModel
{
    //film listesi
    public List<Movie>? Movies { get; set; }

    //listeden belirli tür seçmemi sağlar
    public SelectList? Genres { get; set; }

    //seçtiğim tür
    public string? MovieGenre { get; set; }

    //araştırdığım metin içeriği
    public string? SearchString { get; set; }
}