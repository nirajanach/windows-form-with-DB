Imports System.Data.SqlClient
Imports System.Linq
Imports Microsoft.EntityFrameworkCore

Public Class Form1

    Public accountGuid As Guid

    Public Function CheckGuid() As Boolean
        If accountGuid.GetType Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CheckAndSetGuid()
        If accountGuid.GetType Is Nothing Then
            accountGuid = Guid.NewGuid()

        Else
            accountGuid = accountGuid

        End If
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    ' Set the properties of your entity based on the form input




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' Create a new Account object


        Dim newAccount As New AccountDetail()
        newAccount.Id = accountGuid
        newAccount.Name = txtName.Text
        newAccount.Address = txtAddress.Text
        newAccount.City = txtCity.Text
        newAccount.State = txtState.Text
        Integer.TryParse(txtPostCode.Text, newAccount.PostCode)
        newAccount.Contact = txtContact.Text
        newAccount.FirstName = txtFirstName.Text
        newAccount.LastName = txtLastName.Text
        newAccount.Mobile1 = txtMobile1.Text
        newAccount.Mobile2 = txtMobile2.Text
        Integer.TryParse(txtLandline.Text, newAccount.Landline)
        Integer.TryParse(txtFax.Text, newAccount.Fax)
        newAccount.Email = txtEmail.Text
        newAccount.Email2 = txtEmail2.Text
        newAccount.Website = txtWebsite.Text
        Integer.TryParse(txtABN.Text, newAccount.ABN)



        Try

            ' Create a connection string to connect to your SQL Server database.
            Dim connectionString As String = "Data Source=Jarvis\SQLEXPRESS;Initial Catalog=CustomerDB;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=SQLserver12"


            ' Create a new DbContextOptionsBuilder object and configure it to use SQL Server with the connection string
            Dim optionsBuilder As New DbContextOptionsBuilder(Of AccountDetailContext)
            optionsBuilder.UseSqlServer(connectionString)

            ' Create a new YourDbContext object with the options
            Using db As New AccountDetailContext(optionsBuilder.Options)
                ' Insert the new Account object into the Accounts table
                db.AccountDetails.Add(newAccount)

                ' Save the changes to the database
                If CheckGuid() Then
                    db.Update(newAccount)
                    MessageBox.Show("Succesfully Updated the Database")
                    db.SaveChanges()
                Else
                    db.SaveChanges()
                    MessageBox.Show("Succesfully Added to the Database")

                End If

            End Using

            Dim newForm As New Form2

            newForm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try






    End Sub

    Private Sub btnShowData_Click(sender As Object, e As EventArgs) Handles btnShowData.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

