Imports System.Data.Entity
Imports mvcstore

Namespace Models
    Public Class mvcstoreContext
        Inherits DbContext
        ' You can add custom code to this file. Changes will not be overwritten.
        ' 
        ' If you want Entity Framework to drop and regenerate your database
        ' automatically whenever you change your model schema, add the following
        ' code to the Application_Start method in your Global.asax file.
        ' Note: this will destroy and re-create your database with every model change.
        ' 
        ' System.Data.Entity.Database.SetInitializer(New System.Data.Entity.DropCreateDatabaseIfModelChanges(Of Models.mvcstoreContext)())

        Public Sub New()
            MyBase.New("name=mvcstoreContext")
        End Sub

        Public Property LogOnModels As DbSet(Of LogOnModel)
    End Class


End Namespace


