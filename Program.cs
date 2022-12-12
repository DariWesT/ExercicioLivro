var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Livro Gaga = new Livro("Gaga",400);

app.MapGet("/", () => "O livro " +Gaga.Titulo+ " têm " +Gaga.QntPaginas+ " páginas.");
app.MapGet("/titulo", () => Gaga.Titulo);
app.MapGet("/ler", () => Gaga.PaginasLidas+=7);
app.MapGet("/progresso", () => Gaga.verificaprogresso() + "%");


app.Run();


class Livro
{
    private string titulo;
    private int qntPaginas;
    private int paginasLidas = 0;

    public Livro() {}
    public Livro( string titulo, int qntPaginas) {
        this.Titulo = titulo;
        this.QntPaginas= qntPaginas;
    }
    public double verificaprogresso()
    {
        return((double)this.paginasLidas*100.0) /(double) this.qntPaginas;
    }

    public string Titulo { 
        get => titulo; set => titulo = value;
    }
    public int QntPaginas { 
        get => qntPaginas; set => qntPaginas = value;
    }
    public int PaginasLidas { 
        get => paginasLidas; set => paginasLidas = value; 
    }
}
