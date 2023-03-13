<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.DataModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(52, 53)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowTemplate.Height = 25
        Me.dgvAccounts.Size = New System.Drawing.Size(688, 235)
        Me.dgvAccounts.TabIndex = 0
        '
        'DataModelBindingSource
        '
        Me.DataModelBindingSource.DataSource = GetType(Winforms.AccountDetailContext)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents AccountsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataModelBindingSource As BindingSource
End Class
