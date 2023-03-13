Imports System.Data.Entity
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Options

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Create a connection string to connect to your SQL Server database.
        Dim connectionString As String = "Data Source=Jarvis\SQLEXPRESS;Initial Catalog=CustomerDB;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=SQLserver12"


        ' Create a new DbContextOptionsBuilder object and configure it to use SQL Server with the connection string
        Dim optionsBuilder As New DbContextOptionsBuilder(Of AccountDetailContext)
        optionsBuilder.UseSqlServer(connectionString)

        ' Create a new YourDbContext object with the options
        Using db As New AccountDetailContext(optionsBuilder.Options)


            ' Query the database for all entities in the MyModels table
            Dim myModels As New List(Of AccountDetail)

            myModels = db.AccountDetails.ToList()

            dgvAccounts.DataSource = myModels
        End Using

        Form1.Hide()

    End Sub








    Private Sub dgvAccounts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellDoubleClick

        ' Get the Id value for the selected row
        Dim selectedId As Guid = CType(dgvAccounts.Rows(e.RowIndex).Cells("Id").Value, Guid)

        ' Create a connection string to connect to your SQL Server database.
        Dim connectionString As String = "Data Source=Jarvis\SQLEXPRESS;Initial Catalog=CustomerDB;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=SQLserver12"


        ' Create a new DbContextOptionsBuilder object and configure it to use SQL Server with the connection string
        Dim optionsBuilder As New DbContextOptionsBuilder(Of AccountDetailContext)
        optionsBuilder.UseSqlServer(connectionString)

        ' Create a new YourDbContext object with the options
        Using db As New AccountDetailContext(optionsBuilder.Options)

            ' Find the Account object with the selected Id value
            Dim accountToEdit = db.AccountDetails.Find(selectedId)

            If accountToEdit IsNot Nothing Then
                ' Display a form or dialog box where the user can edit accountToEdit

                Dim newForm As New Form1
                newForm.accountGuid = accountToEdit.Id
                newForm.txtName.Text = accountToEdit.Name
                newForm.txtAddress.Text = accountToEdit.Address
                newForm.txtCity.Text = accountToEdit.City
                newForm.txtState.Text = accountToEdit.State
                newForm.txtPostCode.Text = accountToEdit.PostCode.ToString()
                newForm.txtContact.Text = accountToEdit.Contact
                newForm.txtFirstName.Text = accountToEdit.FirstName
                newForm.txtLastName.Text = accountToEdit.LastName
                newForm.txtMobile1.Text = accountToEdit.Mobile1
                newForm.txtMobile2.Text = accountToEdit.Mobile2
                newForm.txtLandline.Text = accountToEdit.Landline.ToString()
                newForm.txtFax.Text = accountToEdit.Fax.ToString()
                newForm.txtEmail.Text = accountToEdit.Email
                newForm.txtEmail2.Text = accountToEdit.Email2
                newForm.txtWebsite.Text = accountToEdit.Website
                newForm.txtABN.Text = accountToEdit.ABN.ToString()
                newForm.btnSave.Text = "Update Record"
                newForm.btnShowData.Hide()

                newForm.Show()

                ' Save any changes made by calling SaveChanges on your DbContext object
                'db.SaveChanges()
            End If


        End Using


    End Sub
End Class