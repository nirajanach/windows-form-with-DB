
Imports Microsoft.EntityFrameworkCore

Public Class AccountDetailContext
    Inherits DbContext




    Public Sub New(options As DbContextOptions(Of AccountDetailContext))
        MyBase.New(options)
    End Sub



    Public Property AccountDetails As DbSet(Of AccountDetail)



End Class