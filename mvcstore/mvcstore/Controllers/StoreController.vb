Namespace mvcstore
    Public Class StoreController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Store

        Function Index() As ActionResult
            Using storeDB As New MusicStoreEntities()
                ' Retrieve list of Genres from database
                Dim genres = From genre In storeDB.Genres
                             Select genre.Name
                ' Set up our ViewModel
                Dim viewModel = New StoreIndexViewModel() With
                {
                    .Genres = genres.ToList(),
                    .NumberOfGenres = genres.Count()
                }
                Return View(viewModel)
            End Using
        End Function

        ' GET: /Store/GenreMenu
        <ChildActionOnly()>
        Public Function GenreMenu() As ActionResult
            Using db As New MusicStoreEntities()
                Return View(db.Genres.ToList())
            End Using
        End Function


        ' GET: /Store/Browse?Genre=Disco
        Public Function Browse(genre As String)
            Using storeDB As New MusicStoreEntities()
                ' Retrieve Genre and its Associated Albums from database
                Dim genreModel = storeDB.Genres.Include("Albums").Single(Function(g) g.Name.Equals(genre))
                Dim viewModel As New StoreBrowseViewModel() With _
                    {.Genre = genreModel, .Albums = genreModel.Albums.ToList()}
                Return View(viewModel)
            End Using

        End Function

        ' GET: /Store/Details/5
        Public Function Details(id As Integer) As ActionResult
            Using storeDB As New MusicStoreEntities()
                Dim album = storeDB.Albums.Include("Genre").Include("Artist").Single(Function(a) a.AlbumId = id)
                Return View(album)
            End Using
        End Function

    End Class
End Namespace